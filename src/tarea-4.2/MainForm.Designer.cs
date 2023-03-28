namespace tarea_42;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCiudadAirport = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPais = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeparture = new System.Windows.Forms.Button();
            this.btnArrival = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDeparturePais = new System.Windows.Forms.TextBox();
            this.tbArrivalPais = new System.Windows.Forms.TextBox();
            this.tbDepartureCiudadAirport = new System.Windows.Forms.TextBox();
            this.tbArrivalCiudadAirport = new System.Windows.Forms.TextBox();
            this.btnCalcPrice = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPrice, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lstCiudadAirport, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(316, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(307, 124);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ciudad - Aeropuerto";
            // 
            // lstCiudadAirport
            // 
            this.lstCiudadAirport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCiudadAirport.FormattingEnabled = true;
            this.lstCiudadAirport.ItemHeight = 15;
            this.lstCiudadAirport.Location = new System.Drawing.Point(3, 24);
            this.lstCiudadAirport.Name = "lstCiudadAirport";
            this.lstCiudadAirport.Size = new System.Drawing.Size(301, 97);
            this.lstCiudadAirport.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lstPais, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 124);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pais";
            // 
            // lstPais
            // 
            this.lstPais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPais.FormattingEnabled = true;
            this.lstPais.ItemHeight = 15;
            this.lstPais.Location = new System.Drawing.Point(3, 24);
            this.lstPais.Name = "lstPais";
            this.lstPais.Size = new System.Drawing.Size(301, 97);
            this.lstPais.TabIndex = 1;
            this.lstPais.SelectedValueChanged += new System.EventHandler(this.lstPais_SelectedValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnDeparture);
            this.flowLayoutPanel1.Controls.Add(this.btnArrival);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(629, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 124);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnDeparture
            // 
            this.btnDeparture.AutoSize = true;
            this.btnDeparture.Location = new System.Drawing.Point(3, 3);
            this.btnDeparture.Name = "btnDeparture";
            this.btnDeparture.Padding = new System.Windows.Forms.Padding(3);
            this.btnDeparture.Size = new System.Drawing.Size(97, 31);
            this.btnDeparture.TabIndex = 0;
            this.btnDeparture.Text = "Salida";
            this.btnDeparture.UseVisualStyleBackColor = true;
            this.btnDeparture.Click += new System.EventHandler(this.btnDeparture_Click);
            // 
            // btnArrival
            // 
            this.btnArrival.AutoSize = true;
            this.btnArrival.Location = new System.Drawing.Point(3, 40);
            this.btnArrival.Name = "btnArrival";
            this.btnArrival.Padding = new System.Windows.Forms.Padding(3);
            this.btnArrival.Size = new System.Drawing.Size(97, 31);
            this.btnArrival.TabIndex = 1;
            this.btnArrival.Text = "Llegada";
            this.btnArrival.UseVisualStyleBackColor = true;
            this.btnArrival.Click += new System.EventHandler(this.btnArrival_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPrice.ForeColor = System.Drawing.Color.Red;
            this.tbPrice.Location = new System.Drawing.Point(630, 166);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 34);
            this.tbPrice.TabIndex = 3;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbDeparturePais, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbArrivalPais, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbDepartureCiudadAirport, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbArrivalCiudadAirport, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnCalcPrice, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(620, 100);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salida:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Llegada:";
            // 
            // tbDeparturePais
            // 
            this.tbDeparturePais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeparturePais.Location = new System.Drawing.Point(60, 13);
            this.tbDeparturePais.Name = "tbDeparturePais";
            this.tbDeparturePais.Size = new System.Drawing.Size(146, 23);
            this.tbDeparturePais.TabIndex = 2;
            // 
            // tbArrivalPais
            // 
            this.tbArrivalPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArrivalPais.Location = new System.Drawing.Point(60, 63);
            this.tbArrivalPais.Name = "tbArrivalPais";
            this.tbArrivalPais.Size = new System.Drawing.Size(146, 23);
            this.tbArrivalPais.TabIndex = 3;
            // 
            // tbDepartureCiudadAirport
            // 
            this.tbDepartureCiudadAirport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDepartureCiudadAirport.Location = new System.Drawing.Point(212, 13);
            this.tbDepartureCiudadAirport.Name = "tbDepartureCiudadAirport";
            this.tbDepartureCiudadAirport.Size = new System.Drawing.Size(298, 23);
            this.tbDepartureCiudadAirport.TabIndex = 4;
            // 
            // tbArrivalCiudadAirport
            // 
            this.tbArrivalCiudadAirport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArrivalCiudadAirport.Location = new System.Drawing.Point(212, 63);
            this.tbArrivalCiudadAirport.Name = "tbArrivalCiudadAirport";
            this.tbArrivalCiudadAirport.Size = new System.Drawing.Size(298, 23);
            this.tbArrivalCiudadAirport.TabIndex = 5;
            // 
            // btnCalcPrice
            // 
            this.btnCalcPrice.AutoSize = true;
            this.btnCalcPrice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalcPrice.Location = new System.Drawing.Point(518, 15);
            this.btnCalcPrice.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.btnCalcPrice.Name = "btnCalcPrice";
            this.tableLayoutPanel4.SetRowSpan(this.btnCalcPrice, 2);
            this.btnCalcPrice.Size = new System.Drawing.Size(97, 70);
            this.btnCalcPrice.TabIndex = 6;
            this.btnCalcPrice.Text = "Calcular Precio";
            this.btnCalcPrice.UseVisualStyleBackColor = true;
            this.btnCalcPrice.Click += new System.EventHandler(this.btnCalcPrice_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 236);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(750, 275);
            this.Name = "MainForm";
            this.Text = "Reserva de Vuelos";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel3;
    private Label label2;
    private ListBox lstCiudadAirport;
    private TableLayoutPanel tableLayoutPanel2;
    private Label label1;
    private ListBox lstPais;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button btnDeparture;
    private Button btnArrival;
    private TextBox tbPrice;
    private TableLayoutPanel tableLayoutPanel4;
    private Label label3;
    private Label label4;
    private TextBox tbDeparturePais;
    private TextBox tbArrivalPais;
    private TextBox tbDepartureCiudadAirport;
    private TextBox tbArrivalCiudadAirport;
    private Button btnCalcPrice;
}
