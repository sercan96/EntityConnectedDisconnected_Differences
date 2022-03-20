
namespace _20220217_EntityConectedDisconnected
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_connected = new System.Windows.Forms.ListBox();
            this.lst_disconnected = new System.Windows.Forms.ListBox();
            this.lst_entity = new System.Windows.Forms.ListBox();
            this.lbl_conper = new System.Windows.Forms.Label();
            this.lbl_dconper = new System.Windows.Forms.Label();
            this.lbl_entityper = new System.Windows.Forms.Label();
            this.btn_connection = new System.Windows.Forms.Button();
            this.btn_disconnection = new System.Windows.Forms.Button();
            this.btn_entity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(283, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disconnected";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(552, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lst_connected
            // 
            this.lst_connected.FormattingEnabled = true;
            this.lst_connected.ItemHeight = 16;
            this.lst_connected.Location = new System.Drawing.Point(29, 83);
            this.lst_connected.Name = "lst_connected";
            this.lst_connected.Size = new System.Drawing.Size(248, 356);
            this.lst_connected.TabIndex = 3;
            // 
            // lst_disconnected
            // 
            this.lst_disconnected.FormattingEnabled = true;
            this.lst_disconnected.ItemHeight = 16;
            this.lst_disconnected.Location = new System.Drawing.Point(288, 83);
            this.lst_disconnected.Name = "lst_disconnected";
            this.lst_disconnected.Size = new System.Drawing.Size(248, 356);
            this.lst_disconnected.TabIndex = 4;
            // 
            // lst_entity
            // 
            this.lst_entity.FormattingEnabled = true;
            this.lst_entity.ItemHeight = 16;
            this.lst_entity.Location = new System.Drawing.Point(557, 83);
            this.lst_entity.Name = "lst_entity";
            this.lst_entity.Size = new System.Drawing.Size(248, 356);
            this.lst_entity.TabIndex = 5;
            // 
            // lbl_conper
            // 
            this.lbl_conper.BackColor = System.Drawing.Color.Black;
            this.lbl_conper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_conper.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_conper.Location = new System.Drawing.Point(24, 458);
            this.lbl_conper.Name = "lbl_conper";
            this.lbl_conper.Size = new System.Drawing.Size(253, 38);
            this.lbl_conper.TabIndex = 6;
            this.lbl_conper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_dconper
            // 
            this.lbl_dconper.BackColor = System.Drawing.Color.Black;
            this.lbl_dconper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dconper.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_dconper.Location = new System.Drawing.Point(283, 458);
            this.lbl_dconper.Name = "lbl_dconper";
            this.lbl_dconper.Size = new System.Drawing.Size(253, 38);
            this.lbl_dconper.TabIndex = 7;
            this.lbl_dconper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_entityper
            // 
            this.lbl_entityper.BackColor = System.Drawing.Color.Black;
            this.lbl_entityper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_entityper.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_entityper.Location = new System.Drawing.Point(552, 458);
            this.lbl_entityper.Name = "lbl_entityper";
            this.lbl_entityper.Size = new System.Drawing.Size(253, 38);
            this.lbl_entityper.TabIndex = 8;
            this.lbl_entityper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_connection
            // 
            this.btn_connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_connection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_connection.Location = new System.Drawing.Point(29, 516);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(248, 55);
            this.btn_connection.TabIndex = 9;
            this.btn_connection.Text = "Connected";
            this.btn_connection.UseVisualStyleBackColor = false;
            this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
            // 
            // btn_disconnection
            // 
            this.btn_disconnection.BackColor = System.Drawing.Color.Blue;
            this.btn_disconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_disconnection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_disconnection.Location = new System.Drawing.Point(288, 516);
            this.btn_disconnection.Name = "btn_disconnection";
            this.btn_disconnection.Size = new System.Drawing.Size(248, 55);
            this.btn_disconnection.TabIndex = 10;
            this.btn_disconnection.Text = "Disconnected";
            this.btn_disconnection.UseVisualStyleBackColor = false;
            this.btn_disconnection.Click += new System.EventHandler(this.btn_disconnection_Click);
            // 
            // btn_entity
            // 
            this.btn_entity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_entity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_entity.Location = new System.Drawing.Point(557, 516);
            this.btn_entity.Name = "btn_entity";
            this.btn_entity.Size = new System.Drawing.Size(248, 55);
            this.btn_entity.TabIndex = 11;
            this.btn_entity.Text = "Entity";
            this.btn_entity.UseVisualStyleBackColor = false;
            this.btn_entity.Click += new System.EventHandler(this.btn_entity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(832, 583);
            this.Controls.Add(this.btn_entity);
            this.Controls.Add(this.btn_disconnection);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.lbl_entityper);
            this.Controls.Add(this.lbl_dconper);
            this.Controls.Add(this.lbl_conper);
            this.Controls.Add(this.lst_entity);
            this.Controls.Add(this.lst_disconnected);
            this.Controls.Add(this.lst_connected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "w";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_connected;
        private System.Windows.Forms.ListBox lst_disconnected;
        private System.Windows.Forms.ListBox lst_entity;
        private System.Windows.Forms.Label lbl_conper;
        private System.Windows.Forms.Label lbl_dconper;
        private System.Windows.Forms.Label lbl_entityper;
        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.Button btn_disconnection;
        private System.Windows.Forms.Button btn_entity;
    }
}

