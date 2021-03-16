using System;
using System.Windows.Forms;

namespace ShutdownTimer
{
    partial class Shutdown
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shutdown));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hour_only_pick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_hour = new System.Windows.Forms.TextBox();
            this.input_min = new System.Windows.Forms.TextBox();
            this.input_sec = new System.Windows.Forms.TextBox();
            this.lb_hour = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_desligarDayHour = new System.Windows.Forms.Button();
            this.btn_desligarHour = new System.Windows.Forms.Button();
            this.btn_desligarToHour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(206, 32);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // hour_only_pick
            // 
            this.hour_only_pick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hour_only_pick.Location = new System.Drawing.Point(206, 84);
            this.hour_only_pick.Name = "hour_only_pick";
            this.hour_only_pick.ShowUpDown = true;
            this.hour_only_pick.Size = new System.Drawing.Size(200, 20);
            this.hour_only_pick.TabIndex = 2;
            this.hour_only_pick.ValueChanged += new System.EventHandler(this.hour_only_pick_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shutdown on day at:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shutdown at:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shutdown from:";
            // 
            // input_hour
            // 
            this.input_hour.Location = new System.Drawing.Point(206, 148);
            this.input_hour.Name = "input_hour";
            this.input_hour.Size = new System.Drawing.Size(62, 20);
            this.input_hour.TabIndex = 6;
            this.input_hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_hour_KeyPress);
            // 
            // input_min
            // 
            this.input_min.Location = new System.Drawing.Point(276, 148);
            this.input_min.Name = "input_min";
            this.input_min.Size = new System.Drawing.Size(62, 20);
            this.input_min.TabIndex = 7;
            this.input_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_min_KeyPress);
            // 
            // input_sec
            // 
            this.input_sec.Location = new System.Drawing.Point(344, 148);
            this.input_sec.Name = "input_sec";
            this.input_sec.Size = new System.Drawing.Size(62, 20);
            this.input_sec.TabIndex = 8;
            this.input_sec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_sec_KeyPress);
            // 
            // lb_hour
            // 
            this.lb_hour.AutoSize = true;
            this.lb_hour.Location = new System.Drawing.Point(206, 129);
            this.lb_hour.Name = "lb_hour";
            this.lb_hour.Size = new System.Drawing.Size(35, 13);
            this.lb_hour.TabIndex = 9;
            this.lb_hour.Text = "Hours";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Location = new System.Drawing.Point(273, 129);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(44, 13);
            this.lb_min.TabIndex = 10;
            this.lb_min.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seconds";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(27, 175);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(450, 33);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Remove any pending shutdown";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_desligarDayHour
            // 
            this.btn_desligarDayHour.Location = new System.Drawing.Point(413, 28);
            this.btn_desligarDayHour.Name = "btn_desligarDayHour";
            this.btn_desligarDayHour.Size = new System.Drawing.Size(64, 23);
            this.btn_desligarDayHour.TabIndex = 13;
            this.btn_desligarDayHour.Text = "Shutdown";
            this.btn_desligarDayHour.UseVisualStyleBackColor = true;
            this.btn_desligarDayHour.Click += new System.EventHandler(this.btn_desligarDayHour_Click);
            // 
            // btn_desligarHour
            // 
            this.btn_desligarHour.Location = new System.Drawing.Point(413, 81);
            this.btn_desligarHour.Name = "btn_desligarHour";
            this.btn_desligarHour.Size = new System.Drawing.Size(64, 23);
            this.btn_desligarHour.TabIndex = 14;
            this.btn_desligarHour.Text = "Shutdown";
            this.btn_desligarHour.UseVisualStyleBackColor = true;
            this.btn_desligarHour.Click += new System.EventHandler(this.btn_desligarHour_Click);
            // 
            // btn_desligarToHour
            // 
            this.btn_desligarToHour.Location = new System.Drawing.Point(413, 145);
            this.btn_desligarToHour.Name = "btn_desligarToHour";
            this.btn_desligarToHour.Size = new System.Drawing.Size(64, 23);
            this.btn_desligarToHour.TabIndex = 15;
            this.btn_desligarToHour.Text = "Shutdown";
            this.btn_desligarToHour.UseVisualStyleBackColor = true;
            this.btn_desligarToHour.Click += new System.EventHandler(this.btn_desligarToHour_Click);
            // 
            // Shutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 220);
            this.Controls.Add(this.btn_desligarToHour);
            this.Controls.Add(this.btn_desligarHour);
            this.Controls.Add(this.btn_desligarDayHour);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.lb_hour);
            this.Controls.Add(this.input_sec);
            this.Controls.Add(this.input_min);
            this.Controls.Add(this.input_hour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hour_only_pick);
            this.Controls.Add(this.dateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shutdown";
            this.Text = "ShutdownTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker hour_only_pick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_min;
        private System.Windows.Forms.TextBox input_sec;
        private System.Windows.Forms.Label lb_hour;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label label4;
        private Button btn_reset;
        private Button btn_desligarDayHour;
        private Button btn_desligarHour;
        private Button btn_desligarToHour;
        public TextBox input_hour;
    }
}

