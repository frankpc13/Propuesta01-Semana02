namespace Semana02_Propuesta01
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
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalEmployees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.labelTotalOrders = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de empleado";
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.AllowUserToAddRows = false;
            this.dataGridEmployees.AllowUserToDeleteRows = false;
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployees.Location = new System.Drawing.Point(12, 42);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.ReadOnly = true;
            this.dataGridEmployees.RowTemplate.Height = 24;
            this.dataGridEmployees.Size = new System.Drawing.Size(776, 252);
            this.dataGridEmployees.TabIndex = 2;
            this.dataGridEmployees.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridEmployees_CellMouseDoubleClick);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(254, 16);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(363, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro. de empleados";
            // 
            // labelTotalEmployees
            // 
            this.labelTotalEmployees.AutoSize = true;
            this.labelTotalEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalEmployees.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEmployees.Location = new System.Drawing.Point(668, 297);
            this.labelTotalEmployees.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelTotalEmployees.Name = "labelTotalEmployees";
            this.labelTotalEmployees.Size = new System.Drawing.Size(120, 32);
            this.labelTotalEmployees.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pedidos registrados";
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToDeleteRows = false;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(12, 382);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.RowTemplate.Height = 24;
            this.dataGridOrder.Size = new System.Drawing.Size(776, 252);
            this.dataGridOrder.TabIndex = 7;
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.AutoSize = true;
            this.labelTotalOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalOrders.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOrders.Location = new System.Drawing.Point(668, 637);
            this.labelTotalOrders.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(120, 32);
            this.labelTotalOrders.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nro. de pedidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 728);
            this.Controls.Add(this.labelTotalOrders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalEmployees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.dataGridEmployees);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridEmployees;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalEmployees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.Label labelTotalOrders;
        private System.Windows.Forms.Label label6;
    }
}

