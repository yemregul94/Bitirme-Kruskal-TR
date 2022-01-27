namespace KruskalProjesi
{
    partial class AnaForm
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.baslikLabel = new System.Windows.Forms.Label();
            this.girisliButton = new System.Windows.Forms.Button();
            this.altPanel = new System.Windows.Forms.TableLayoutPanel();
            this.standartButton = new System.Windows.Forms.Button();
            this.anaMenuButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.ilerleButton = new System.Windows.Forms.Button();
            this.dugumEkleButton = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.kenarEkleButton = new System.Windows.Forms.Button();
            this.sagPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AnlatimBox = new System.Windows.Forms.RichTextBox();
            this.kenarListBox = new System.Windows.Forms.ListBox();
            this.gecikmePanel = new System.Windows.Forms.TableLayoutPanel();
            this.gecikmeBar = new System.Windows.Forms.TrackBar();
            this.gecikmeLabel = new System.Windows.Forms.Label();
            this.cizimPanel = new System.Windows.Forms.Panel();
            this.anaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.altPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.sagPanel.SuspendLayout();
            this.gecikmePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gecikmeBar)).BeginInit();
            this.anaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // baslikLabel
            // 
            this.baslikLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baslikLabel.Font = new System.Drawing.Font("Unispace", 45F);
            this.baslikLabel.Location = new System.Drawing.Point(20, 9);
            this.baslikLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.baslikLabel.Name = "baslikLabel";
            this.baslikLabel.Size = new System.Drawing.Size(856, 149);
            this.baslikLabel.TabIndex = 0;
            this.baslikLabel.Text = "Kruskal Algoritması\r\nEğitim Modellemesi";
            this.baslikLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // girisliButton
            // 
            this.girisliButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girisliButton.BackColor = System.Drawing.Color.Black;
            this.girisliButton.Font = new System.Drawing.Font("Unispace", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisliButton.Location = new System.Drawing.Point(439, 5);
            this.girisliButton.Name = "girisliButton";
            this.girisliButton.Size = new System.Drawing.Size(430, 170);
            this.girisliButton.TabIndex = 2;
            this.girisliButton.Text = "Değer girişi yapılarak Kruskal";
            this.girisliButton.UseVisualStyleBackColor = false;
            this.girisliButton.Click += new System.EventHandler(this.GirisliButton_Click);
            this.girisliButton.MouseEnter += new System.EventHandler(this.GirisliButton_MouseEnter);
            this.girisliButton.MouseLeave += new System.EventHandler(this.GirisliButton_MouseLeave);
            // 
            // altPanel
            // 
            this.altPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.altPanel.ColumnCount = 2;
            this.altPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altPanel.Controls.Add(this.standartButton, 0, 0);
            this.altPanel.Controls.Add(this.girisliButton, 1, 0);
            this.altPanel.Location = new System.Drawing.Point(12, 471);
            this.altPanel.Name = "altPanel";
            this.altPanel.RowCount = 1;
            this.altPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altPanel.Size = new System.Drawing.Size(872, 178);
            this.altPanel.TabIndex = 3;
            // 
            // standartButton
            // 
            this.standartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.standartButton.BackColor = System.Drawing.Color.Black;
            this.standartButton.Font = new System.Drawing.Font("Unispace", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.standartButton.Location = new System.Drawing.Point(3, 5);
            this.standartButton.Name = "standartButton";
            this.standartButton.Size = new System.Drawing.Size(430, 170);
            this.standartButton.TabIndex = 1;
            this.standartButton.Text = "Standart örnek ile Kruskal";
            this.standartButton.UseVisualStyleBackColor = false;
            this.standartButton.Click += new System.EventHandler(this.StandartButton_Click);
            this.standartButton.MouseEnter += new System.EventHandler(this.StandartButton_MouseEnter);
            this.standartButton.MouseLeave += new System.EventHandler(this.StandartButton_MouseLeave);
            // 
            // anaMenuButton
            // 
            this.anaMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anaMenuButton.BackColor = System.Drawing.Color.LawnGreen;
            this.anaMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaMenuButton.ForeColor = System.Drawing.Color.Black;
            this.anaMenuButton.Location = new System.Drawing.Point(3, 3);
            this.anaMenuButton.Name = "anaMenuButton";
            this.anaMenuButton.Size = new System.Drawing.Size(141, 67);
            this.anaMenuButton.TabIndex = 4;
            this.anaMenuButton.Text = "Menüye Dön";
            this.anaMenuButton.UseVisualStyleBackColor = false;
            this.anaMenuButton.Click += new System.EventHandler(this.AnaMenuButton_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.ColumnCount = 6;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.menuPanel.Controls.Add(this.anaMenuButton, 0, 0);
            this.menuPanel.Controls.Add(this.hesaplaButton, 1, 0);
            this.menuPanel.Controls.Add(this.ilerleButton, 2, 0);
            this.menuPanel.Controls.Add(this.dugumEkleButton, 3, 0);
            this.menuPanel.Controls.Add(this.temizleButton, 5, 0);
            this.menuPanel.Controls.Add(this.kenarEkleButton, 4, 0);
            this.menuPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuPanel.Location = new System.Drawing.Point(4, 583);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 1;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.menuPanel.Size = new System.Drawing.Size(888, 73);
            this.menuPanel.TabIndex = 6;
            this.menuPanel.Visible = false;
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hesaplaButton.BackColor = System.Drawing.Color.LawnGreen;
            this.hesaplaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplaButton.ForeColor = System.Drawing.Color.Black;
            this.hesaplaButton.Location = new System.Drawing.Point(150, 3);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(141, 67);
            this.hesaplaButton.TabIndex = 4;
            this.hesaplaButton.Text = "Hesapla";
            this.hesaplaButton.UseVisualStyleBackColor = false;
            this.hesaplaButton.Click += new System.EventHandler(this.HesaplaButton_Click);
            // 
            // ilerleButton
            // 
            this.ilerleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ilerleButton.BackColor = System.Drawing.Color.LawnGreen;
            this.ilerleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilerleButton.ForeColor = System.Drawing.Color.Black;
            this.ilerleButton.Location = new System.Drawing.Point(297, 3);
            this.ilerleButton.Name = "ilerleButton";
            this.ilerleButton.Size = new System.Drawing.Size(141, 67);
            this.ilerleButton.TabIndex = 6;
            this.ilerleButton.Text = "İlerle";
            this.ilerleButton.UseVisualStyleBackColor = false;
            this.ilerleButton.Click += new System.EventHandler(this.İlerleButton_ClickAsync);
            // 
            // dugumEkleButton
            // 
            this.dugumEkleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dugumEkleButton.BackColor = System.Drawing.Color.LawnGreen;
            this.dugumEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dugumEkleButton.ForeColor = System.Drawing.Color.Black;
            this.dugumEkleButton.Location = new System.Drawing.Point(444, 3);
            this.dugumEkleButton.Name = "dugumEkleButton";
            this.dugumEkleButton.Size = new System.Drawing.Size(141, 67);
            this.dugumEkleButton.TabIndex = 5;
            this.dugumEkleButton.Text = "Düğüm Ekle";
            this.dugumEkleButton.UseVisualStyleBackColor = false;
            this.dugumEkleButton.Click += new System.EventHandler(this.DugumEkleButton_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temizleButton.BackColor = System.Drawing.Color.LawnGreen;
            this.temizleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.ForeColor = System.Drawing.Color.Black;
            this.temizleButton.Location = new System.Drawing.Point(738, 3);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(147, 67);
            this.temizleButton.TabIndex = 7;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = false;
            this.temizleButton.Click += new System.EventHandler(this.TemizleButton_Click);
            // 
            // kenarEkleButton
            // 
            this.kenarEkleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kenarEkleButton.BackColor = System.Drawing.Color.LawnGreen;
            this.kenarEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kenarEkleButton.ForeColor = System.Drawing.Color.Black;
            this.kenarEkleButton.Location = new System.Drawing.Point(591, 3);
            this.kenarEkleButton.Name = "kenarEkleButton";
            this.kenarEkleButton.Size = new System.Drawing.Size(141, 67);
            this.kenarEkleButton.TabIndex = 6;
            this.kenarEkleButton.Text = "Kenar Ekle";
            this.kenarEkleButton.UseVisualStyleBackColor = false;
            this.kenarEkleButton.Click += new System.EventHandler(this.KenarEkleButton_Click);
            // 
            // sagPanel
            // 
            this.sagPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sagPanel.ColumnCount = 1;
            this.sagPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sagPanel.Controls.Add(this.AnlatimBox, 0, 1);
            this.sagPanel.Controls.Add(this.kenarListBox, 0, 0);
            this.sagPanel.Controls.Add(this.gecikmePanel, 0, 2);
            this.sagPanel.Location = new System.Drawing.Point(639, 0);
            this.sagPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.sagPanel.Name = "sagPanel";
            this.sagPanel.RowCount = 3;
            this.sagPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.98093F));
            this.sagPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.01907F));
            this.sagPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.sagPanel.Size = new System.Drawing.Size(246, 577);
            this.sagPanel.TabIndex = 6;
            // 
            // AnlatimBox
            // 
            this.AnlatimBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnlatimBox.BackColor = System.Drawing.Color.Lavender;
            this.AnlatimBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnlatimBox.Location = new System.Drawing.Point(3, 231);
            this.AnlatimBox.Name = "AnlatimBox";
            this.AnlatimBox.ReadOnly = true;
            this.AnlatimBox.Size = new System.Drawing.Size(240, 297);
            this.AnlatimBox.TabIndex = 8;
            this.AnlatimBox.Text = "";
            // 
            // kenarListBox
            // 
            this.kenarListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kenarListBox.BackColor = System.Drawing.Color.Lavender;
            this.kenarListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kenarListBox.FormattingEnabled = true;
            this.kenarListBox.ItemHeight = 20;
            this.kenarListBox.Items.AddRange(new object[] {
            " "});
            this.kenarListBox.Location = new System.Drawing.Point(3, 3);
            this.kenarListBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.kenarListBox.Name = "kenarListBox";
            this.kenarListBox.Size = new System.Drawing.Size(240, 224);
            this.kenarListBox.TabIndex = 6;
            // 
            // gecikmePanel
            // 
            this.gecikmePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gecikmePanel.ColumnCount = 2;
            this.gecikmePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.48598F));
            this.gecikmePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.51402F));
            this.gecikmePanel.Controls.Add(this.gecikmeBar, 0, 0);
            this.gecikmePanel.Controls.Add(this.gecikmeLabel, 1, 0);
            this.gecikmePanel.Location = new System.Drawing.Point(0, 531);
            this.gecikmePanel.Margin = new System.Windows.Forms.Padding(0);
            this.gecikmePanel.Name = "gecikmePanel";
            this.gecikmePanel.RowCount = 1;
            this.gecikmePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gecikmePanel.Size = new System.Drawing.Size(246, 46);
            this.gecikmePanel.TabIndex = 9;
            // 
            // gecikmeBar
            // 
            this.gecikmeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gecikmeBar.LargeChange = 1;
            this.gecikmeBar.Location = new System.Drawing.Point(3, 3);
            this.gecikmeBar.Maximum = 5;
            this.gecikmeBar.Name = "gecikmeBar";
            this.gecikmeBar.Size = new System.Drawing.Size(152, 40);
            this.gecikmeBar.TabIndex = 10;
            this.gecikmeBar.ValueChanged += new System.EventHandler(this.GecikmeBar_ValueChanged);
            // 
            // gecikmeLabel
            // 
            this.gecikmeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gecikmeLabel.AutoSize = true;
            this.gecikmeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gecikmeLabel.Location = new System.Drawing.Point(161, 0);
            this.gecikmeLabel.Name = "gecikmeLabel";
            this.gecikmeLabel.Size = new System.Drawing.Size(82, 46);
            this.gecikmeLabel.TabIndex = 11;
            this.gecikmeLabel.Text = "Gecikme süresi ";
            this.gecikmeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cizimPanel
            // 
            this.cizimPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cizimPanel.AutoSize = true;
            this.cizimPanel.BackColor = System.Drawing.Color.Lavender;
            this.cizimPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cizimPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cizimPanel.Enabled = false;
            this.cizimPanel.ForeColor = System.Drawing.Color.Black;
            this.cizimPanel.Location = new System.Drawing.Point(3, 3);
            this.cizimPanel.Name = "cizimPanel";
            this.cizimPanel.Size = new System.Drawing.Size(630, 574);
            this.cizimPanel.TabIndex = 5;
            this.cizimPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CizimPanel_Paint);
            this.cizimPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CizimPanel_MouseClick);
            // 
            // anaPanel
            // 
            this.anaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anaPanel.ColumnCount = 2;
            this.anaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.73424F));
            this.anaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.26577F));
            this.anaPanel.Controls.Add(this.cizimPanel, 0, 0);
            this.anaPanel.Controls.Add(this.sagPanel, 1, 0);
            this.anaPanel.Location = new System.Drawing.Point(4, 3);
            this.anaPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.anaPanel.Name = "anaPanel";
            this.anaPanel.RowCount = 1;
            this.anaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.anaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.anaPanel.Size = new System.Drawing.Size(888, 580);
            this.anaPanel.TabIndex = 7;
            this.anaPanel.Visible = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(896, 661);
            this.Controls.Add(this.anaPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.altPanel);
            this.Controls.Add(this.baslikLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(11);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kruskal Algoritması Eğitim Modellemesi";
            this.altPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.sagPanel.ResumeLayout(false);
            this.gecikmePanel.ResumeLayout(false);
            this.gecikmePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gecikmeBar)).EndInit();
            this.anaPanel.ResumeLayout(false);
            this.anaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label baslikLabel;
        private System.Windows.Forms.Button girisliButton;
        private System.Windows.Forms.TableLayoutPanel altPanel;
        private System.Windows.Forms.Button standartButton;
        private System.Windows.Forms.Button anaMenuButton;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.Button dugumEkleButton;
        private System.Windows.Forms.Button hesaplaButton;
        private System.Windows.Forms.Button kenarEkleButton;
        private System.Windows.Forms.Button ilerleButton;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.TableLayoutPanel sagPanel;
        private System.Windows.Forms.RichTextBox AnlatimBox;
        private System.Windows.Forms.ListBox kenarListBox;
        private System.Windows.Forms.Panel cizimPanel;
        private System.Windows.Forms.TableLayoutPanel anaPanel;
        private System.Windows.Forms.TableLayoutPanel gecikmePanel;
        private System.Windows.Forms.TrackBar gecikmeBar;
        private System.Windows.Forms.Label gecikmeLabel;
    }
}

