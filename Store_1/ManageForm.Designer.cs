namespace Store_1
{
    partial class ManageForm
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
            this.OperationNameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.FirstPriceTextBox = new System.Windows.Forms.TextBox();
            this.FirstPriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PostionTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OperationNameLabel
            // 
            this.OperationNameLabel.AutoSize = true;
            this.OperationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationNameLabel.Location = new System.Drawing.Point(23, 9);
            this.OperationNameLabel.Name = "OperationNameLabel";
            this.OperationNameLabel.Size = new System.Drawing.Size(296, 29);
            this.OperationNameLabel.TabIndex = 21;
            this.OperationNameLabel.Text = "ДОБАВЛЕНИЕ ТОВАРА";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(186, 265);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(145, 34);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "ОТМЕНА";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.Location = new System.Drawing.Point(28, 265);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(145, 34);
            this.ConfirmButton.TabIndex = 19;
            this.ConfirmButton.Text = "ПОДТВЕРДИТЬ";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // FirstPriceTextBox
            // 
            this.FirstPriceTextBox.Location = new System.Drawing.Point(28, 230);
            this.FirstPriceTextBox.MaxLength = 5;
            this.FirstPriceTextBox.Name = "FirstPriceTextBox";
            this.FirstPriceTextBox.Size = new System.Drawing.Size(303, 20);
            this.FirstPriceTextBox.TabIndex = 18;
            this.FirstPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstPriceTextBox_KeyPress);
            // 
            // FirstPriceLabel
            // 
            this.FirstPriceLabel.AutoSize = true;
            this.FirstPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPriceLabel.Location = new System.Drawing.Point(92, 203);
            this.FirstPriceLabel.Name = "FirstPriceLabel";
            this.FirstPriceLabel.Size = new System.Drawing.Size(183, 24);
            this.FirstPriceLabel.TabIndex = 17;
            this.FirstPriceLabel.Text = "Закупочная цена:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(27, 180);
            this.PriceTextBox.MaxLength = 5;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(303, 20);
            this.PriceTextBox.TabIndex = 16;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextBox_KeyPress);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(138, 153);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(64, 24);
            this.PriceLabel.TabIndex = 15;
            this.PriceLabel.Text = "Цена:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(28, 130);
            this.QuantityTextBox.MaxLength = 5;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(303, 20);
            this.QuantityTextBox.TabIndex = 14;
            this.QuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox_KeyPress);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityLabel.Location = new System.Drawing.Point(110, 103);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(133, 24);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = "Количество:";
            // 
            // PostionTextBox
            // 
            this.PostionTextBox.Location = new System.Drawing.Point(28, 80);
            this.PostionTextBox.MaxLength = 25;
            this.PostionTextBox.Name = "PostionTextBox";
            this.PostionTextBox.Size = new System.Drawing.Size(303, 20);
            this.PostionTextBox.TabIndex = 12;
            //this.PostionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostionTextBox_KeyPress_1);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel.Location = new System.Drawing.Point(92, 53);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(162, 24);
            this.PositionLabel.TabIndex = 11;
            this.PositionLabel.Text = "Наименование:";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(347, 315);
            this.Controls.Add(this.OperationNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.FirstPriceTextBox);
            this.Controls.Add(this.FirstPriceLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PostionTextBox);
            this.Controls.Add(this.PositionLabel);
            this.Name = "ManageForm";
            this.Text = "Управление товаром";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OperationNameLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox FirstPriceTextBox;
        private System.Windows.Forms.Label FirstPriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox PostionTextBox;
        private System.Windows.Forms.Label PositionLabel;
    }
}