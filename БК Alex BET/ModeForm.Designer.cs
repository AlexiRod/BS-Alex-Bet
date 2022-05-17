namespace БК_Alex_BET
{
    partial class ModeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeForm));
            this.btnOwn = new System.Windows.Forms.Button();
            this.btnLeague = new System.Windows.Forms.Button();
            this.btnCup = new System.Windows.Forms.Button();
            this.btnWorldCup = new System.Windows.Forms.Button();
            this.pboxBK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOwn
            // 
            this.btnOwn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOwn.FlatAppearance.BorderSize = 2;
            this.btnOwn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwn.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwn.Location = new System.Drawing.Point(69, 157);
            this.btnOwn.Name = "btnOwn";
            this.btnOwn.Size = new System.Drawing.Size(387, 165);
            this.btnOwn.TabIndex = 0;
            this.btnOwn.Text = "Режим одной ставки";
            this.btnOwn.UseVisualStyleBackColor = false;
            this.btnOwn.Click += new System.EventHandler(this.btnOwn_Click);
            // 
            // btnLeague
            // 
            this.btnLeague.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLeague.FlatAppearance.BorderSize = 2;
            this.btnLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeague.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold);
            this.btnLeague.Location = new System.Drawing.Point(610, 157);
            this.btnLeague.Name = "btnLeague";
            this.btnLeague.Size = new System.Drawing.Size(387, 165);
            this.btnLeague.TabIndex = 1;
            this.btnLeague.Text = "Режим Лиги";
            this.btnLeague.UseVisualStyleBackColor = false;
            this.btnLeague.Click += new System.EventHandler(this.btnLeague_Click);
            // 
            // btnCup
            // 
            this.btnCup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCup.FlatAppearance.BorderSize = 2;
            this.btnCup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCup.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold);
            this.btnCup.Location = new System.Drawing.Point(69, 373);
            this.btnCup.Name = "btnCup";
            this.btnCup.Size = new System.Drawing.Size(387, 165);
            this.btnCup.TabIndex = 2;
            this.btnCup.Text = "Режим Кубка";
            this.btnCup.UseVisualStyleBackColor = false;
            // 
            // btnWorldCup
            // 
            this.btnWorldCup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnWorldCup.FlatAppearance.BorderSize = 2;
            this.btnWorldCup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorldCup.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold);
            this.btnWorldCup.Location = new System.Drawing.Point(610, 373);
            this.btnWorldCup.Name = "btnWorldCup";
            this.btnWorldCup.Size = new System.Drawing.Size(387, 165);
            this.btnWorldCup.TabIndex = 3;
            this.btnWorldCup.Text = "Режим Кубка Мира";
            this.btnWorldCup.UseVisualStyleBackColor = false;
            // 
            // pboxBK
            // 
            this.pboxBK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxBK.Image = global::БК_Alex_BET.Properties.Resources.Логотип_БК;
            this.pboxBK.Location = new System.Drawing.Point(307, 12);
            this.pboxBK.Name = "pboxBK";
            this.pboxBK.Size = new System.Drawing.Size(461, 127);
            this.pboxBK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxBK.TabIndex = 305;
            this.pboxBK.TabStop = false;
            // 
            // ModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::БК_Alex_BET.Properties.Resources.Фон3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1075, 616);
            this.Controls.Add(this.pboxBK);
            this.Controls.Add(this.btnWorldCup);
            this.Controls.Add(this.btnCup);
            this.Controls.Add(this.btnLeague);
            this.Controls.Add(this.btnOwn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1097, 672);
            this.MinimumSize = new System.Drawing.Size(1097, 672);
            this.Name = "ModeForm";
            this.Text = "БК Alex BET";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pboxBK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOwn;
        private System.Windows.Forms.Button btnLeague;
        private System.Windows.Forms.Button btnCup;
        private System.Windows.Forms.Button btnWorldCup;
        private System.Windows.Forms.PictureBox pboxBK;
    }
}

