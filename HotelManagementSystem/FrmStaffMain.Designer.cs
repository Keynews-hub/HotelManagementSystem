namespace HotelManagementSystem
{
    partial class FrmStaffMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_regularPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_show = new System.Windows.Forms.PictureBox();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.grid_showroom = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.list_price = new System.Windows.Forms.Label();
            this.list_status = new System.Windows.Forms.Label();
            this.list_roomName = new System.Windows.Forms.Label();
            this.list_roomType = new System.Windows.Forms.Label();
            this.list_roomID = new System.Windows.Forms.Label();
            this.date_bookFrom = new System.Windows.Forms.DateTimePicker();
            this.clear = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.date_bookTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_showroom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.list_regularPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pb_show);
            this.panel1.Controls.Add(this.btn_schedule);
            this.panel1.Controls.Add(this.grid_showroom);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.list_price);
            this.panel1.Controls.Add(this.list_status);
            this.panel1.Controls.Add(this.list_roomName);
            this.panel1.Controls.Add(this.list_roomType);
            this.panel1.Controls.Add(this.list_roomID);
            this.panel1.Controls.Add(this.date_bookFrom);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_book);
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.date_bookTo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 726);
            this.panel1.TabIndex = 0;
            // 
            // list_regularPrice
            // 
            this.list_regularPrice.AutoSize = true;
            this.list_regularPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_regularPrice.Location = new System.Drawing.Point(175, 182);
            this.list_regularPrice.Name = "list_regularPrice";
            this.list_regularPrice.Size = new System.Drawing.Size(150, 21);
            this.list_regularPrice.TabIndex = 25;
            this.list_regularPrice.Text = "______________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Regular Price :";
            // 
            // pb_show
            // 
            this.pb_show.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pb_show.Location = new System.Drawing.Point(348, 356);
            this.pb_show.Name = "pb_show";
            this.pb_show.Size = new System.Drawing.Size(1015, 343);
            this.pb_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_show.TabIndex = 23;
            this.pb_show.TabStop = false;
            // 
            // btn_schedule
            // 
            this.btn_schedule.Location = new System.Drawing.Point(34, 397);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(294, 46);
            this.btn_schedule.TabIndex = 22;
            this.btn_schedule.Text = "Schedule";
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // grid_showroom
            // 
            this.grid_showroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_showroom.Location = new System.Drawing.Point(348, 19);
            this.grid_showroom.Name = "grid_showroom";
            this.grid_showroom.RowHeadersWidth = 51;
            this.grid_showroom.RowTemplate.Height = 24;
            this.grid_showroom.Size = new System.Drawing.Size(1015, 311);
            this.grid_showroom.TabIndex = 20;
            this.grid_showroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_showroom_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Room ID :";
            // 
            // list_price
            // 
            this.list_price.AutoSize = true;
            this.list_price.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_price.Location = new System.Drawing.Point(132, 473);
            this.list_price.Name = "list_price";
            this.list_price.Size = new System.Drawing.Size(150, 21);
            this.list_price.TabIndex = 18;
            this.list_price.Text = "______________";
            // 
            // list_status
            // 
            this.list_status.AutoSize = true;
            this.list_status.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_status.Location = new System.Drawing.Point(175, 140);
            this.list_status.Name = "list_status";
            this.list_status.Size = new System.Drawing.Size(150, 21);
            this.list_status.TabIndex = 17;
            this.list_status.Text = "______________";
            // 
            // list_roomName
            // 
            this.list_roomName.AutoSize = true;
            this.list_roomName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_roomName.Location = new System.Drawing.Point(175, 102);
            this.list_roomName.Name = "list_roomName";
            this.list_roomName.Size = new System.Drawing.Size(150, 21);
            this.list_roomName.TabIndex = 16;
            this.list_roomName.Text = "______________";
            // 
            // list_roomType
            // 
            this.list_roomType.AutoSize = true;
            this.list_roomType.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_roomType.Location = new System.Drawing.Point(175, 65);
            this.list_roomType.Name = "list_roomType";
            this.list_roomType.Size = new System.Drawing.Size(150, 21);
            this.list_roomType.TabIndex = 15;
            this.list_roomType.Text = "______________";
            // 
            // list_roomID
            // 
            this.list_roomID.AutoSize = true;
            this.list_roomID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_roomID.Location = new System.Drawing.Point(175, 28);
            this.list_roomID.Name = "list_roomID";
            this.list_roomID.Size = new System.Drawing.Size(150, 21);
            this.list_roomID.TabIndex = 14;
            this.list_roomID.Text = "______________";
            // 
            // date_bookFrom
            // 
            this.date_bookFrom.Location = new System.Drawing.Point(131, 227);
            this.date_bookFrom.Name = "date_bookFrom";
            this.date_bookFrom.Size = new System.Drawing.Size(193, 22);
            this.date_bookFrom.TabIndex = 13;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(37, 651);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(292, 46);
            this.clear.TabIndex = 12;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(37, 578);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(292, 46);
            this.btn_print.TabIndex = 11;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(33, 513);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(292, 46);
            this.btn_book.TabIndex = 10;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(37, 332);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(288, 46);
            this.btn_check.TabIndex = 9;
            this.btn_check.Text = "Check Room";
            this.btn_check.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "To :";
            // 
            // date_bookTo
            // 
            this.date_bookTo.Location = new System.Drawing.Point(132, 265);
            this.date_bookTo.Name = "date_bookTo";
            this.date_bookTo.Size = new System.Drawing.Size(193, 22);
            this.date_bookTo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "From :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Rp :";
            // 
            // FrmStaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1480, 762);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStaffMain";
            this.Text = "FrmStaffMain";
            this.Load += new System.EventHandler(this.FrmStaffMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_showroom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_bookTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_bookFrom;
        private System.Windows.Forms.Label list_roomID;
        private System.Windows.Forms.Label list_price;
        private System.Windows.Forms.Label list_status;
        private System.Windows.Forms.Label list_roomName;
        private System.Windows.Forms.Label list_roomType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView grid_showroom;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.PictureBox pb_show;
        private System.Windows.Forms.Label list_regularPrice;
        private System.Windows.Forms.Label label8;
    }
}