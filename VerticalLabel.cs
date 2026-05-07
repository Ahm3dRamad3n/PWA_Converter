using System;
using System.Drawing;
using System.Windows.Forms;

namespace PWA_Converter_App
{
    public class VerticalLabel : Label
    {
        // خاصية للتحكم في اتجاه الدوران (اختياري، لزيادة الفائدة)
        private bool _flip = false;
        public bool Flip
        {
            get => _flip;
            set { _flip = value; Invalidate(); } // Invalidate عشان يعيد الرسم وقت التغيير
        }

        public VerticalLabel()
        {
            // بنعطل الـ AutoSize لأنه مابيشتغلش صح مع الرسم المدور
            this.AutoSize = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 1. بنرسم الخلفية زي الـ Label العادي
            using (Brush backBrush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(backBrush, ClientRectangle);
            }

            Graphics g = e.Graphics;
            string text = this.Text;

            if (string.IsNullOrEmpty(text)) return;

            // 2. بنضبط جودة الرسم عشان الكلام يطلع واضح
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            using (Brush brush = new SolidBrush(this.ForeColor))
            using (StringFormat format = new StringFormat())
            {
                // 3. بنضبط محاذاة النص (سنتر عشان يبان أحسن)
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                // 4. عملية الدوران (هنا السحر بيحصل):

                // بنحفظ حالة الـ Graphics الأصلية
                System.Drawing.Drawing2D.GraphicsState state = g.Save();

                // بننقل نقطة الأصل لسنتر الأداة
                g.TranslateTransform(this.Width / 2f, this.Height / 2f);

                // بندور الـ Graphics بزاوية 90 درجة
                if (Flip)
                    g.RotateTransform(-90); // قراءة من أسفل لأعلى (زي بعض كتب المكاتب)
                else
                    g.RotateTransform(90);  // قراءة من أعلى لأسفل (الطريقة الشائعة)

                // 5. بنرسم النص المدور في نقطة الأصل (اللي بقت سنتر الأداة)
                g.DrawString(text, this.Font, brush, 0, 0, format);

                // بنرجع الـ Graphics لحالتها الأصلية
                g.Restore(state);
            }
        }
    }
}