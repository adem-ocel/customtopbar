using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace customform
{
    partial class Topbar
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topbar));
            windowstatusminbutton = new Button();
            closebutton = new Button();
            panel2 = new Panel();
            windowstatemaxbutton = new Button();
            icon = new PictureBox();
            titlepanel = new Panel();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            titlepanel.SuspendLayout();
            SuspendLayout();
            // 
            // windowstatusminbutton
            // 
            windowstatusminbutton.BackColor = SystemColors.Window;
            windowstatusminbutton.BackgroundImage = (Image)resources.GetObject("windowstatusminbutton.BackgroundImage");
            windowstatusminbutton.BackgroundImageLayout = ImageLayout.Stretch;
            windowstatusminbutton.Dock = DockStyle.Right;
            windowstatusminbutton.FlatAppearance.BorderSize = 0;
            windowstatusminbutton.FlatStyle = FlatStyle.Flat;
            windowstatusminbutton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            windowstatusminbutton.Location = new Point(1009, 0);
            windowstatusminbutton.Margin = new Padding(3, 4, 3, 4);
            windowstatusminbutton.Name = "windowstatusminbutton";
            windowstatusminbutton.Size = new Size(31, 35);
            windowstatusminbutton.TabIndex = 5;
            windowstatusminbutton.UseVisualStyleBackColor = false;
            windowstatusminbutton.Click += Windowstatusminbutton_Click;
            // 
            // closebutton
            // 
            closebutton.BackColor = SystemColors.Window;
            closebutton.BackgroundImage = (Image)resources.GetObject("closebutton.BackgroundImage");
            closebutton.BackgroundImageLayout = ImageLayout.Stretch;
            closebutton.Dock = DockStyle.Right;
            closebutton.FlatAppearance.BorderSize = 0;
            closebutton.FlatStyle = FlatStyle.Flat;
            closebutton.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            closebutton.Location = new Point(1071, 0);
            closebutton.Margin = new Padding(3, 4, 3, 4);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(31, 35);
            closebutton.TabIndex = 3;
            closebutton.UseVisualStyleBackColor = false;
            closebutton.Click += Closebutton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 35);
            panel2.TabIndex = 9;
            panel2.MouseDown += libctm_MouseDown;
            panel2.MouseMove += libctm_MouseMove;
            panel2.MouseUp += libctm_MouseUp;
            // 
            // windowstatemaxbutton
            // 
            windowstatemaxbutton.BackColor = SystemColors.Window;
            windowstatemaxbutton.BackgroundImage = (Image)resources.GetObject("windowstatemaxbutton.BackgroundImage");
            windowstatemaxbutton.BackgroundImageLayout = ImageLayout.Stretch;
            windowstatemaxbutton.Dock = DockStyle.Right;
            windowstatemaxbutton.FlatAppearance.BorderSize = 0;
            windowstatemaxbutton.FlatStyle = FlatStyle.Flat;
            windowstatemaxbutton.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            windowstatemaxbutton.Location = new Point(1040, 0);
            windowstatemaxbutton.Margin = new Padding(3, 4, 3, 4);
            windowstatemaxbutton.Name = "windowstatemaxbutton";
            windowstatemaxbutton.Size = new Size(31, 35);
            windowstatemaxbutton.TabIndex = 4;
            windowstatemaxbutton.UseVisualStyleBackColor = false;
            windowstatemaxbutton.Click += Windowstatemaxbutton_Click;
            // 
            // icon
            // 
            icon.Dock = DockStyle.Left;
            icon.Location = new Point(0, 0);
            icon.Margin = new Padding(3, 4, 3, 4);
            icon.Name = "icon";
            icon.Size = new Size(28, 35);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.TabIndex = 10;
            icon.TabStop = false;
            icon.Visible = false;
            icon.BackgroundImageChanged += Icon_BackgroundImageChanged;
            // 
            // titlepanel
            // 
            titlepanel.BackColor = SystemColors.Window;
            titlepanel.Controls.Add(title);
            titlepanel.Dock = DockStyle.Left;
            titlepanel.Location = new Point(28, 0);
            titlepanel.Margin = new Padding(3, 4, 3, 4);
            titlepanel.Name = "titlepanel";
            titlepanel.Size = new Size(53, 35);
            titlepanel.TabIndex = 11;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = SystemColors.Control;
            title.Location = new Point(3, 9);
            title.Name = "title";
            title.Size = new Size(0, 20);
            title.TabIndex = 7;
            title.TextChanged += Title_TextChanged_1;
            // 
            // Topbar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(titlepanel);
            Controls.Add(icon);
            Controls.Add(panel2);
            Controls.Add(windowstatusminbutton);
            Controls.Add(windowstatemaxbutton);
            Controls.Add(closebutton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Topbar";
            Size = new Size(1102, 35);
            Load += libctm_Load;
            BackColorChanged += Topbar_BackColorChanged;
            MouseDown += libctm_MouseDown;
            MouseMove += libctm_MouseMove;
            MouseUp += libctm_MouseUp;
            ParentChanged += Topbar_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            titlepanel.ResumeLayout(false);
            titlepanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button windowstatusminbutton;
        public System.Windows.Forms.Button windowstatemaxbutton;
        public System.Windows.Forms.Button closebutton;
        public Panel panel2;
        public PictureBox icon;
        private Panel titlepanel;
        public Label title;
    }
}
