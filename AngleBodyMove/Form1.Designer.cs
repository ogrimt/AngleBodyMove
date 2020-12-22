
namespace AngleBodyMove
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_button = new System.Windows.Forms.Button();
            this.angle_value = new System.Windows.Forms.TextBox();
            this.V_0_value = new System.Windows.Forms.TextBox();
            this.angle_label = new System.Windows.Forms.Label();
            this.V_0_label = new System.Windows.Forms.Label();
            this.length_label = new System.Windows.Forms.Label();
            this.Hmax_label = new System.Windows.Forms.Label();
            this.t_label = new System.Windows.Forms.Label();
            this.L_value = new System.Windows.Forms.TextBox();
            this.Hmax_value = new System.Windows.Forms.TextBox();
            this.t_value = new System.Windows.Forms.TextBox();
            this.angle_unit_label = new System.Windows.Forms.Label();
            this.speed_unit_label = new System.Windows.Forms.Label();
            this.length_unit_label = new System.Windows.Forms.Label();
            this.max_height_unit_label = new System.Windows.Forms.Label();
            this.time_unit_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(153, 32);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(91, 51);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Старт";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // angle_value
            // 
            this.angle_value.Location = new System.Drawing.Point(29, 29);
            this.angle_value.Name = "angle_value";
            this.angle_value.Size = new System.Drawing.Size(89, 20);
            this.angle_value.TabIndex = 1;
            // 
            // V_0_value
            // 
            this.V_0_value.Location = new System.Drawing.Point(26, 75);
            this.V_0_value.Name = "V_0_value";
            this.V_0_value.Size = new System.Drawing.Size(89, 20);
            this.V_0_value.TabIndex = 2;
            // 
            // angle_label
            // 
            this.angle_label.AutoSize = true;
            this.angle_label.Location = new System.Drawing.Point(61, 13);
            this.angle_label.Name = "angle_label";
            this.angle_label.Size = new System.Drawing.Size(32, 13);
            this.angle_label.TabIndex = 3;
            this.angle_label.Text = "Угол";
            // 
            // V_0_label
            // 
            this.V_0_label.AutoSize = true;
            this.V_0_label.Location = new System.Drawing.Point(23, 59);
            this.V_0_label.Name = "V_0_label";
            this.V_0_label.Size = new System.Drawing.Size(112, 13);
            this.V_0_label.TabIndex = 4;
            this.V_0_label.Text = "Начальная скорость";
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.Location = new System.Drawing.Point(258, 29);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(104, 13);
            this.length_label.TabIndex = 5;
            this.length_label.Text = "Дальность полета:";
            // 
            // Hmax_label
            // 
            this.Hmax_label.AutoSize = true;
            this.Hmax_label.Location = new System.Drawing.Point(258, 59);
            this.Hmax_label.Name = "Hmax_label";
            this.Hmax_label.Size = new System.Drawing.Size(175, 13);
            this.Hmax_label.TabIndex = 6;
            this.Hmax_label.Text = "Максимальная высота подъема:";
            // 
            // t_label
            // 
            this.t_label.AutoSize = true;
            this.t_label.Location = new System.Drawing.Point(258, 87);
            this.t_label.Name = "t_label";
            this.t_label.Size = new System.Drawing.Size(96, 13);
            this.t_label.TabIndex = 7;
            this.t_label.Text = "Время движения:";
            // 
            // L_value
            // 
            this.L_value.Location = new System.Drawing.Point(368, 22);
            this.L_value.Name = "L_value";
            this.L_value.ReadOnly = true;
            this.L_value.Size = new System.Drawing.Size(100, 20);
            this.L_value.TabIndex = 8;
            // 
            // Hmax_value
            // 
            this.Hmax_value.Location = new System.Drawing.Point(439, 56);
            this.Hmax_value.Name = "Hmax_value";
            this.Hmax_value.ReadOnly = true;
            this.Hmax_value.Size = new System.Drawing.Size(100, 20);
            this.Hmax_value.TabIndex = 9;
            // 
            // t_value
            // 
            this.t_value.Location = new System.Drawing.Point(368, 84);
            this.t_value.Name = "t_value";
            this.t_value.ReadOnly = true;
            this.t_value.Size = new System.Drawing.Size(100, 20);
            this.t_value.TabIndex = 10;
            // 
            // angle_unit_label
            // 
            this.angle_unit_label.AutoSize = true;
            this.angle_unit_label.Location = new System.Drawing.Point(124, 32);
            this.angle_unit_label.Name = "angle_unit_label";
            this.angle_unit_label.Size = new System.Drawing.Size(11, 13);
            this.angle_unit_label.TabIndex = 11;
            this.angle_unit_label.Text = "°";
            // 
            // speed_unit_label
            // 
            this.speed_unit_label.AutoSize = true;
            this.speed_unit_label.Location = new System.Drawing.Point(121, 82);
            this.speed_unit_label.Name = "speed_unit_label";
            this.speed_unit_label.Size = new System.Drawing.Size(26, 13);
            this.speed_unit_label.TabIndex = 12;
            this.speed_unit_label.Text = "м/с";
            // 
            // length_unit_label
            // 
            this.length_unit_label.AutoSize = true;
            this.length_unit_label.Location = new System.Drawing.Point(475, 28);
            this.length_unit_label.Name = "length_unit_label";
            this.length_unit_label.Size = new System.Drawing.Size(15, 13);
            this.length_unit_label.TabIndex = 13;
            this.length_unit_label.Text = "м";
            // 
            // max_height_unit_label
            // 
            this.max_height_unit_label.AutoSize = true;
            this.max_height_unit_label.Location = new System.Drawing.Point(545, 63);
            this.max_height_unit_label.Name = "max_height_unit_label";
            this.max_height_unit_label.Size = new System.Drawing.Size(15, 13);
            this.max_height_unit_label.TabIndex = 14;
            this.max_height_unit_label.Text = "м";
            // 
            // time_unit_label
            // 
            this.time_unit_label.AutoSize = true;
            this.time_unit_label.Location = new System.Drawing.Point(474, 91);
            this.time_unit_label.Name = "time_unit_label";
            this.time_unit_label.Size = new System.Drawing.Size(13, 13);
            this.time_unit_label.TabIndex = 15;
            this.time_unit_label.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.time_unit_label);
            this.Controls.Add(this.max_height_unit_label);
            this.Controls.Add(this.length_unit_label);
            this.Controls.Add(this.speed_unit_label);
            this.Controls.Add(this.angle_unit_label);
            this.Controls.Add(this.t_value);
            this.Controls.Add(this.Hmax_value);
            this.Controls.Add(this.L_value);
            this.Controls.Add(this.t_label);
            this.Controls.Add(this.Hmax_label);
            this.Controls.Add(this.length_label);
            this.Controls.Add(this.V_0_label);
            this.Controls.Add(this.angle_label);
            this.Controls.Add(this.V_0_value);
            this.Controls.Add(this.angle_value);
            this.Controls.Add(this.start_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Движение тела, брошенного под углом к горизонту";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox angle_value;
        private System.Windows.Forms.TextBox V_0_value;
        private System.Windows.Forms.Label angle_label;
        private System.Windows.Forms.Label V_0_label;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.Label Hmax_label;
        private System.Windows.Forms.Label t_label;
        private System.Windows.Forms.TextBox L_value;
        private System.Windows.Forms.TextBox Hmax_value;
        private System.Windows.Forms.TextBox t_value;
        private System.Windows.Forms.Label angle_unit_label;
        private System.Windows.Forms.Label speed_unit_label;
        private System.Windows.Forms.Label length_unit_label;
        private System.Windows.Forms.Label max_height_unit_label;
        private System.Windows.Forms.Label time_unit_label;
    }
}

