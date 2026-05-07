
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace PWAConverterApp
{
    public class PWAProcessor
    {
        private static string GetPrefixUrlFormat(string url)
        {
            if (url.StartsWith("http://"))
            {
                return "http://";
            }
            if (url.StartsWith("https://"))
            {
                return "https://";
            }
            if (url.StartsWith("/"))
            {
                return "/";
            }
            return "./";
        }
        private static string prefixUrlFormat = string.Empty;
        public static void GeneratePWA(string htmlFilePath, string appName, string shortName, string startUrl, string display, string backgroundColor, string themeColor, string iconPath, List<string> serviceWorkerFiles, string outputFolderPath)
        {
            prefixUrlFormat = GetPrefixUrlFormat(startUrl);

            if (!Directory.Exists(outputFolderPath))
            {
                Directory.CreateDirectory(outputFolderPath);
            }

            // Copy index.html to output folder
            File.Copy(htmlFilePath, Path.Combine(outputFolderPath, "index.html"), true);

            // Add link to manifest.json and service worker registration in index.html And any other necessary meta tags for PWA
            string indexHtmlPath = Path.Combine(outputFolderPath, "index.html");
            string indexHtmlContent = File.ReadAllText(indexHtmlPath);
            StringBuilder headBuilder = new StringBuilder();
            // add $"<link rel=\"manifest\" href=\"/manifest.json\">" within the <head> section of index.html
            int headCloseTagIndex = indexHtmlContent.IndexOf("</head>", StringComparison.OrdinalIgnoreCase);
            if (headCloseTagIndex != -1)
            {
                headBuilder.AppendLine($"<link rel=\"manifest\" href=\"{prefixUrlFormat}manifest.json\">");
                headBuilder.AppendLine($"<meta name=\"theme-color\" content=\"{themeColor}\">");
                headBuilder.AppendLine($"<link rel=\"icon\" href=\"{prefixUrlFormat}icons/icon-192x192.png\">");
                headBuilder.AppendLine($"<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                indexHtmlContent = indexHtmlContent.Insert(headCloseTagIndex, headBuilder.ToString());
            }
            // Add service worker registration script before closing </body> tag
            int bodyCloseTagIndex = indexHtmlContent.IndexOf("</body>", StringComparison.OrdinalIgnoreCase);
            if (bodyCloseTagIndex != -1)
            {
                StringBuilder bodyBuilder = new StringBuilder();
                bodyBuilder.AppendLine("<script>");
                bodyBuilder.AppendLine("if ('serviceWorker' in navigator) {");
                bodyBuilder.AppendLine("  window.addEventListener('load', function() {");
                bodyBuilder.AppendLine($"    navigator.serviceWorker.register('{prefixUrlFormat}service-worker.js').then(function(registration) " + "{");
                bodyBuilder.AppendLine("      console.log('ServiceWorker registration successful with scope: ', registration.scope);");
                bodyBuilder.AppendLine("    }, function(err) {");
                bodyBuilder.AppendLine("      console.log('ServiceWorker registration failed: ', err);");
                bodyBuilder.AppendLine("    });");
                bodyBuilder.AppendLine("  });");
                bodyBuilder.AppendLine("}");
                bodyBuilder.AppendLine("</script>");
                indexHtmlContent = indexHtmlContent.Insert(bodyCloseTagIndex, bodyBuilder.ToString());
            }

            File.WriteAllText(indexHtmlPath, indexHtmlContent);


            // Generate manifest.json
            GenerateManifest(appName, shortName, startUrl, display, backgroundColor, themeColor, iconPath, outputFolderPath);

            // Generate service-worker.js
            GenerateServiceWorker(outputFolderPath, serviceWorkerFiles);

            // Generate icons (placeholder for now)
            GeneratePWAIcons(iconPath, outputFolderPath);
        }

        private static void GenerateManifest(string appName, string shortName, string startUrl, string display, string backgroundColor, string themeColor, string iconPath, string outputFolderPath)
        {
            JObject manifest = new JObject();
            manifest["name"] = appName;
            manifest["short_name"] = shortName;
            manifest["start_url"] = startUrl;
            manifest["display"] = display;
            manifest["background_color"] = backgroundColor;
            manifest["theme_color"] = themeColor;

            JArray icons = new JArray();
            // Placeholder for icons - actual icon generation will be more complex
            // put all sizes in the icons array
            int[] sizes = { 192, 512 };
            foreach (int size in sizes)
            {
                icons.Add(new JObject
                {
                    ["src"] = $"{prefixUrlFormat}icons/icon-{size}x{size}.png",
                    ["sizes"] = $"{size}x{size}",
                    ["type"] = "image/png",
                    ["purpose"] = "maskable any"
                });
            }
            manifest["icons"] = icons;

            string manifestJson = manifest.ToString(Formatting.Indented);
            File.WriteAllText(Path.Combine(outputFolderPath, "manifest.json"), manifestJson);
        }

        private static void GenerateServiceWorker(string outputFolderPath, List<string> serviceWorkerFiles)
        {
            StringBuilder cacheFilesBuilder = new StringBuilder();
            foreach (string file in serviceWorkerFiles)
            {
                cacheFilesBuilder.AppendLine($"  '{prefixUrlFormat}{file}',");
            }
            string serviceWorkerContent = @$"const CACHE_NAME = 'pwa-cache-v1';
const urlsToCache = [
  '{prefixUrlFormat}',
{cacheFilesBuilder.ToString()}
];
" + @"
self.addEventListener('install', event => {
  event.waitUntil(
    caches.open(CACHE_NAME)
      .then(cache => {
        console.log('Opened cache');
        return cache.addAll(urlsToCache);
      })
  );
});

self.addEventListener('fetch', event => {
  event.respondWith(
    caches.match(event.request)
      .then(response => {
        // Cache hit - return response
        if (response) {
          return response;
        }
        return fetch(event.request);
      })
  );
});

self.addEventListener('activate', event => {
  const cacheWhitelist = [CACHE_NAME];
  event.waitUntil(
    caches.keys().then(cacheNames => {
      return Promise.all(
        cacheNames.map(cacheName => {
          if (cacheWhitelist.indexOf(cacheName) === -1) {
            return caches.delete(cacheName);
          }
        })
      );
    })
  );
});";

            File.WriteAllText(Path.Combine(outputFolderPath, "service-worker.js"), serviceWorkerContent);
        }

        private static void GeneratePWAIcons(string iconPath, string outputFolderPath)
        {
            if (string.IsNullOrEmpty(iconPath) || !File.Exists(iconPath))
            {
                // No icon provided or icon file not found
                return;
            }

            string iconsFolderPath = Path.Combine(outputFolderPath, "icons");
            if (!Directory.Exists(iconsFolderPath))
            {
                Directory.CreateDirectory(iconsFolderPath);
            }

            try
            {
                using (Image originalImage = Image.FromFile(iconPath))
                {
                    int[] sizes = { 192, 512 };
                    foreach (int size in sizes)
                    {
                        using (Bitmap resizedImage = new Bitmap(size, size))
                        {
                            using (Graphics graphics = Graphics.FromImage(resizedImage))
                            {
                                graphics.DrawImage(originalImage, 0, 0, size, size);
                            }
                            resizedImage.Save(Path.Combine(iconsFolderPath, $"icon-{size}x{size}.png"), ImageFormat.Png);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                Console.WriteLine($"Error generating icons: {ex.Message}");
            }
        }

        public static void LoadExistingPWA(string pwaRootPath, out string appName, out string shortName, out string startUrl, out string display, out string backgroundColor, out string themeColor, out string iconPath, out List<string> serviceWorkerFiles)
        {
            appName = shortName = startUrl = display = backgroundColor = themeColor = iconPath = string.Empty;

            string manifestPath = Path.Combine(pwaRootPath, "manifest.json");
            if (File.Exists(manifestPath))
            {
                string manifestJson = File.ReadAllText(manifestPath);
                JObject manifest = JObject.Parse(manifestJson);

                appName = manifest["name"]?.ToString() ?? string.Empty;
                shortName = manifest["short_name"]?.ToString() ?? string.Empty;
                startUrl = manifest["start_url"]?.ToString() ?? string.Empty;
                display = manifest["display"]?.ToString() ?? string.Empty;
                backgroundColor = manifest["background_color"]?.ToString() ?? string.Empty;
                themeColor = manifest["theme_color"]?.ToString() ?? string.Empty;

                prefixUrlFormat = GetPrefixUrlFormat(startUrl);

                // Attempt to find an icon path (this is a simplification)
                JArray icons = manifest["icons"] as JArray;
                if (icons != null && icons.Count > 0)
                {
                    iconPath = Path.Combine(pwaRootPath, icons[0]["src"]?.ToString() ?? string.Empty);
                    iconPath = iconPath.Replace(prefixUrlFormat, string.Empty).Replace("/", "\\");
                }
            }

            string serviceWorkerPath = Path.Combine(pwaRootPath, "service-worker.js");
            serviceWorkerFiles = new List<string>();
            if (File.Exists(serviceWorkerPath))
            {
                string serviceWorkerContent = File.ReadAllText(serviceWorkerPath);
                JArray urlsToCache = ExtractUrlsToCache(serviceWorkerContent);
                if (urlsToCache != null)
                {
                    foreach (var url in urlsToCache)
                    {
                        if (!string.IsNullOrEmpty(url.ToString()))
                        {
                            serviceWorkerFiles.Add(url.ToString());
                        }
                    }
                }
            }
        }

        private static JArray ExtractUrlsToCache(string serviceWorkerContent)
        {
            // This is a very simplified extraction logic and may not cover all cases
            int urlsToCacheIndex = serviceWorkerContent.IndexOf("const urlsToCache = [", StringComparison.OrdinalIgnoreCase);
            if (urlsToCacheIndex != -1)
            {
                int startIndex = serviceWorkerContent.IndexOf('[', urlsToCacheIndex);
                int endIndex = serviceWorkerContent.IndexOf(']', startIndex);
                if (startIndex != -1 && endIndex != -1)
                {
                    string urlsArrayContent = serviceWorkerContent.Substring(startIndex, endIndex - startIndex + 1);
                    try
                    {
                        JArray urlsToCache = JArray.Parse(urlsArrayContent);
                        // remove the prefixUrlFormat from each url if it exists
                        for (int i = 0; i < urlsToCache.Count; i++)
                        {
                            string url = urlsToCache[i].ToString();
                            if (url.StartsWith(prefixUrlFormat))
                            {
                                urlsToCache[i] = url.Substring(prefixUrlFormat.Length);
                            }
                        }
                        return urlsToCache;
                    }
                    catch (JsonException)
                    {
                        // Handle JSON parsing error if necessary
                    }
                }
            }
            return null;
        }

        public static void ModifyPWA(string pwaRootPath, string appName, string shortName, string startUrl, string display, string backgroundColor, string themeColor, string newIconPath, List<string> serviceWorkerFiles)
        {
            prefixUrlFormat = GetPrefixUrlFormat(startUrl);
            // Update manifest.json
            string manifestPath = Path.Combine(pwaRootPath, "manifest.json");
            if (File.Exists(manifestPath))
            {
                string manifestJson = File.ReadAllText(manifestPath);
                JObject manifest = JObject.Parse(manifestJson);

                manifest["name"] = appName;
                manifest["short_name"] = shortName;
                manifest["start_url"] = startUrl;
                manifest["display"] = display;
                manifest["background_color"] = backgroundColor;
                manifest["theme_color"] = themeColor;

                // Update icons if a new one is provided
                if (!string.IsNullOrEmpty(newIconPath) && File.Exists(newIconPath))
                {
                    // Clear existing icons and generate new ones
                    string iconsFolderPath = Path.Combine(pwaRootPath, "icons");
                    
                    GeneratePWAIcons(newIconPath, pwaRootPath);

                    // Update manifest icons array (assuming icon-512x512.png is the main one)
                    JArray icons = new JArray();
                    int[] sizes = { 192, 512 };
                    foreach (int size in sizes)
                    {
                        icons.Add(new JObject
                        {
                            ["src"] = $"{prefixUrlFormat}icons/icon-{size}x{size}.png",
                            ["sizes"] = $"{size}x{size}",
                            ["type"] = "image/png",
                            ["purpose"] = "maskable any"
                        });
                    }
                    manifest["icons"] = icons;
                }

                File.WriteAllText(manifestPath, manifest.ToString(Formatting.Indented));
            }

            // Update service-worker.js 
            string serviceWorkerPath = Path.Combine(pwaRootPath, "service-worker.js");
            if (File.Exists(serviceWorkerPath))
            { 
                GenerateServiceWorker(pwaRootPath, serviceWorkerFiles);
            }

            // For simplicity, service worker is not modified here. If changes are needed, 
            // a more sophisticated logic would be required to update it.
        }
    }
}
