<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.KeluaranGambar = New System.Windows.Forms.PictureBox()
        Me.KapasitasKeranjangKeyUp = New System.Windows.Forms.NumericUpDown()
        Me.KapasitasKeranjang = New System.Windows.Forms.Label()
        Me.PesanError = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.Label()
        Me.ButtonBersihkanKeranjang = New System.Windows.Forms.Button()
        Me.MasukanJumlahBarang = New System.Windows.Forms.NumericUpDown()
        Me.JumlahBarang = New System.Windows.Forms.Label()
        Me.MasukanKodeBarang = New System.Windows.Forms.TextBox()
        Me.KodeBarang = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonMasukanKeranjang = New System.Windows.Forms.Button()
        Me.KeluaranHargaBarang = New System.Windows.Forms.TextBox()
        Me.HargaBarang = New System.Windows.Forms.Label()
        Me.KeluaranNamaBarang = New System.Windows.Forms.TextBox()
        Me.NamaBarang = New System.Windows.Forms.Label()
        Me.KeluaranKodeBarang = New System.Windows.Forms.TextBox()
        Me.KodeBarangAvailable = New System.Windows.Forms.Label()
        Me.ButtonPeriksa = New System.Windows.Forms.Button()
        Me.KeluaranKapasitas = New System.Windows.Forms.TextBox()
        Me.Kapasitas = New System.Windows.Forms.Label()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.KeluaranStruk = New System.Windows.Forms.RichTextBox()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.PesanError2 = New System.Windows.Forms.TextBox()
        Me.ButtonBayar = New System.Windows.Forms.Button()
        Me.KeluaranKembali = New System.Windows.Forms.TextBox()
        Me.Kembali = New System.Windows.Forms.Label()
        Me.BayarKeyup = New System.Windows.Forms.NumericUpDown()
        Me.Bayar = New System.Windows.Forms.Label()
        Me.KeluaranTotalBayar = New System.Windows.Forms.TextBox()
        Me.TotalBayar = New System.Windows.Forms.Label()
        Me.DiskonKeyup = New System.Windows.Forms.NumericUpDown()
        Me.DIskon = New System.Windows.Forms.Label()
        Me.KeluaranJumlahBayar = New System.Windows.Forms.TextBox()
        Me.JumlahBayar = New System.Windows.Forms.Label()
        Me.KeluaranKeranjang = New System.Windows.Forms.ListView()
        Me.No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KodeBarangKeranjang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NamaBarangKeranjang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Jumlah = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Harga = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Keranjang = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.KeluaranGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KapasitasKeranjangKeyUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasukanJumlahBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BayarKeyup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiskonKeyup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.KeluaranGambar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KapasitasKeranjangKeyUp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KapasitasKeranjang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PesanError)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Nama)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBersihkanKeranjang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MasukanJumlahBarang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.JumlahBarang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MasukanKodeBarang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KodeBarang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonExit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonClear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonMasukanKeranjang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KeluaranHargaBarang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.HargaBarang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KeluaranNamaBarang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NamaBarang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KeluaranKodeBarang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KodeBarangAvailable)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonPeriksa)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.KeluaranKapasitas)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Kapasitas)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonCetak)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KeluaranStruk)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonBatal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PesanError2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonBayar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KeluaranKembali)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Kembali)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BayarKeyup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Bayar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KeluaranTotalBayar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalBayar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DiskonKeyup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DIskon)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KeluaranJumlahBayar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.JumlahBayar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KeluaranKeranjang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Keranjang)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 271
        Me.SplitContainer1.TabIndex = 0
        '
        'KeluaranGambar
        '
        Me.KeluaranGambar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.KeluaranGambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KeluaranGambar.Location = New System.Drawing.Point(15, 355)
        Me.KeluaranGambar.Name = "KeluaranGambar"
        Me.KeluaranGambar.Size = New System.Drawing.Size(75, 75)
        Me.KeluaranGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.KeluaranGambar.TabIndex = 17
        Me.KeluaranGambar.TabStop = False
        '
        'KapasitasKeranjangKeyUp
        '
        Me.KapasitasKeranjangKeyUp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KapasitasKeranjangKeyUp.Location = New System.Drawing.Point(15, 90)
        Me.KapasitasKeranjangKeyUp.Name = "KapasitasKeranjangKeyUp"
        Me.KapasitasKeranjangKeyUp.Size = New System.Drawing.Size(246, 20)
        Me.KapasitasKeranjangKeyUp.TabIndex = 18
        Me.KapasitasKeranjangKeyUp.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'KapasitasKeranjang
        '
        Me.KapasitasKeranjang.AutoSize = True
        Me.KapasitasKeranjang.Location = New System.Drawing.Point(15, 70)
        Me.KapasitasKeranjang.Name = "KapasitasKeranjang"
        Me.KapasitasKeranjang.Size = New System.Drawing.Size(104, 13)
        Me.KapasitasKeranjang.TabIndex = 17
        Me.KapasitasKeranjang.Text = "Kapasitas Keranjang"
        '
        'PesanError
        '
        Me.PesanError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PesanError.Enabled = False
        Me.PesanError.Location = New System.Drawing.Point(15, 170)
        Me.PesanError.Name = "PesanError"
        Me.PesanError.Size = New System.Drawing.Size(246, 20)
        Me.PesanError.TabIndex = 17
        '
        'Nama
        '
        Me.Nama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Nama.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Nama.Location = New System.Drawing.Point(20, 30)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(224, 13)
        Me.Nama.TabIndex = 15
        Me.Nama.Text = "SELAMAT DATANG DI MARKISA BDP"
        Me.Nama.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonBersihkanKeranjang
        '
        Me.ButtonBersihkanKeranjang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBersihkanKeranjang.Location = New System.Drawing.Point(110, 380)
        Me.ButtonBersihkanKeranjang.Name = "ButtonBersihkanKeranjang"
        Me.ButtonBersihkanKeranjang.Size = New System.Drawing.Size(151, 25)
        Me.ButtonBersihkanKeranjang.TabIndex = 14
        Me.ButtonBersihkanKeranjang.Text = "Bersihkan Keranjang"
        Me.ButtonBersihkanKeranjang.UseVisualStyleBackColor = True
        '
        'MasukanJumlahBarang
        '
        Me.MasukanJumlahBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MasukanJumlahBarang.Location = New System.Drawing.Point(175, 220)
        Me.MasukanJumlahBarang.Name = "MasukanJumlahBarang"
        Me.MasukanJumlahBarang.Size = New System.Drawing.Size(81, 20)
        Me.MasukanJumlahBarang.TabIndex = 0
        '
        'JumlahBarang
        '
        Me.JumlahBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JumlahBarang.AutoSize = True
        Me.JumlahBarang.Location = New System.Drawing.Point(175, 200)
        Me.JumlahBarang.Name = "JumlahBarang"
        Me.JumlahBarang.Size = New System.Drawing.Size(40, 13)
        Me.JumlahBarang.TabIndex = 14
        Me.JumlahBarang.Text = "Jumlah"
        '
        'MasukanKodeBarang
        '
        Me.MasukanKodeBarang.Location = New System.Drawing.Point(15, 140)
        Me.MasukanKodeBarang.Name = "MasukanKodeBarang"
        Me.MasukanKodeBarang.Size = New System.Drawing.Size(150, 20)
        Me.MasukanKodeBarang.TabIndex = 13
        '
        'KodeBarang
        '
        Me.KodeBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KodeBarang.AutoSize = True
        Me.KodeBarang.Location = New System.Drawing.Point(15, 120)
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.Size = New System.Drawing.Size(69, 13)
        Me.KodeBarang.TabIndex = 0
        Me.KodeBarang.Text = "Kode Barang"
        '
        'ButtonExit
        '
        Me.ButtonExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonExit.Location = New System.Drawing.Point(196, 410)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(65, 25)
        Me.ButtonExit.TabIndex = 12
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonClear.Location = New System.Drawing.Point(110, 410)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(65, 25)
        Me.ButtonClear.TabIndex = 11
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonMasukanKeranjang
        '
        Me.ButtonMasukanKeranjang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMasukanKeranjang.Location = New System.Drawing.Point(110, 350)
        Me.ButtonMasukanKeranjang.Name = "ButtonMasukanKeranjang"
        Me.ButtonMasukanKeranjang.Size = New System.Drawing.Size(151, 25)
        Me.ButtonMasukanKeranjang.TabIndex = 10
        Me.ButtonMasukanKeranjang.Text = "Masukan Keranjang"
        Me.ButtonMasukanKeranjang.UseVisualStyleBackColor = True
        '
        'KeluaranHargaBarang
        '
        Me.KeluaranHargaBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeluaranHargaBarang.Enabled = False
        Me.KeluaranHargaBarang.Location = New System.Drawing.Point(15, 320)
        Me.KeluaranHargaBarang.Name = "KeluaranHargaBarang"
        Me.KeluaranHargaBarang.Size = New System.Drawing.Size(246, 20)
        Me.KeluaranHargaBarang.TabIndex = 9
        '
        'HargaBarang
        '
        Me.HargaBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HargaBarang.AutoSize = True
        Me.HargaBarang.Location = New System.Drawing.Point(15, 300)
        Me.HargaBarang.Name = "HargaBarang"
        Me.HargaBarang.Size = New System.Drawing.Size(73, 13)
        Me.HargaBarang.TabIndex = 8
        Me.HargaBarang.Text = "Harga Barang"
        '
        'KeluaranNamaBarang
        '
        Me.KeluaranNamaBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeluaranNamaBarang.Enabled = False
        Me.KeluaranNamaBarang.Location = New System.Drawing.Point(15, 270)
        Me.KeluaranNamaBarang.Name = "KeluaranNamaBarang"
        Me.KeluaranNamaBarang.Size = New System.Drawing.Size(246, 20)
        Me.KeluaranNamaBarang.TabIndex = 7
        '
        'NamaBarang
        '
        Me.NamaBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NamaBarang.Location = New System.Drawing.Point(15, 250)
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.Size = New System.Drawing.Size(111, 23)
        Me.NamaBarang.TabIndex = 6
        Me.NamaBarang.Text = "Nama Barang"
        '
        'KeluaranKodeBarang
        '
        Me.KeluaranKodeBarang.Enabled = False
        Me.KeluaranKodeBarang.Location = New System.Drawing.Point(15, 220)
        Me.KeluaranKodeBarang.Name = "KeluaranKodeBarang"
        Me.KeluaranKodeBarang.Size = New System.Drawing.Size(145, 20)
        Me.KeluaranKodeBarang.TabIndex = 5
        '
        'KodeBarangAvailable
        '
        Me.KodeBarangAvailable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KodeBarangAvailable.AutoSize = True
        Me.KodeBarangAvailable.Location = New System.Drawing.Point(15, 200)
        Me.KodeBarangAvailable.Name = "KodeBarangAvailable"
        Me.KodeBarangAvailable.Size = New System.Drawing.Size(69, 13)
        Me.KodeBarangAvailable.TabIndex = 4
        Me.KodeBarangAvailable.Text = "Kode Barang"
        '
        'ButtonPeriksa
        '
        Me.ButtonPeriksa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPeriksa.Location = New System.Drawing.Point(180, 137)
        Me.ButtonPeriksa.Name = "ButtonPeriksa"
        Me.ButtonPeriksa.Size = New System.Drawing.Size(81, 25)
        Me.ButtonPeriksa.TabIndex = 2
        Me.ButtonPeriksa.Text = "Periksa"
        Me.ButtonPeriksa.UseVisualStyleBackColor = True
        '
        'KeluaranKapasitas
        '
        Me.KeluaranKapasitas.Enabled = False
        Me.KeluaranKapasitas.Location = New System.Drawing.Point(455, 7)
        Me.KeluaranKapasitas.Name = "KeluaranKapasitas"
        Me.KeluaranKapasitas.Size = New System.Drawing.Size(50, 20)
        Me.KeluaranKapasitas.TabIndex = 20
        '
        'Kapasitas
        '
        Me.Kapasitas.AutoSize = True
        Me.Kapasitas.Location = New System.Drawing.Point(400, 10)
        Me.Kapasitas.Name = "Kapasitas"
        Me.Kapasitas.Size = New System.Drawing.Size(53, 13)
        Me.Kapasitas.TabIndex = 19
        Me.Kapasitas.Text = "Kapasitas"
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCetak.Location = New System.Drawing.Point(224, 365)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(280, 25)
        Me.ButtonCetak.TabIndex = 18
        Me.ButtonCetak.Text = "Cetak"
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'KeluaranStruk
        '
        Me.KeluaranStruk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeluaranStruk.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KeluaranStruk.Location = New System.Drawing.Point(224, 150)
        Me.KeluaranStruk.Name = "KeluaranStruk"
        Me.KeluaranStruk.ReadOnly = True
        Me.KeluaranStruk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.KeluaranStruk.Size = New System.Drawing.Size(280, 190)
        Me.KeluaranStruk.TabIndex = 17
        Me.KeluaranStruk.Text = ""
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBatal.Location = New System.Drawing.Point(109, 365)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(95, 25)
        Me.ButtonBatal.TabIndex = 16
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'PesanError2
        '
        Me.PesanError2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PesanError2.Enabled = False
        Me.PesanError2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PesanError2.ForeColor = System.Drawing.SystemColors.Window
        Me.PesanError2.Location = New System.Drawing.Point(15, 410)
        Me.PesanError2.Name = "PesanError2"
        Me.PesanError2.Size = New System.Drawing.Size(489, 26)
        Me.PesanError2.TabIndex = 14
        Me.PesanError2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonBayar
        '
        Me.ButtonBayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonBayar.Location = New System.Drawing.Point(15, 365)
        Me.ButtonBayar.Name = "ButtonBayar"
        Me.ButtonBayar.Size = New System.Drawing.Size(95, 25)
        Me.ButtonBayar.TabIndex = 13
        Me.ButtonBayar.Text = "Bayar"
        Me.ButtonBayar.UseVisualStyleBackColor = True
        '
        'KeluaranKembali
        '
        Me.KeluaranKembali.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeluaranKembali.Enabled = False
        Me.KeluaranKembali.Location = New System.Drawing.Point(15, 320)
        Me.KeluaranKembali.Name = "KeluaranKembali"
        Me.KeluaranKembali.Size = New System.Drawing.Size(189, 20)
        Me.KeluaranKembali.TabIndex = 12
        '
        'Kembali
        '
        Me.Kembali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Kembali.AutoSize = True
        Me.Kembali.Location = New System.Drawing.Point(15, 300)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.Size = New System.Drawing.Size(44, 13)
        Me.Kembali.TabIndex = 11
        Me.Kembali.Text = "Kembali"
        '
        'BayarKeyup
        '
        Me.BayarKeyup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BayarKeyup.Location = New System.Drawing.Point(15, 270)
        Me.BayarKeyup.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.BayarKeyup.Name = "BayarKeyup"
        Me.BayarKeyup.Size = New System.Drawing.Size(189, 20)
        Me.BayarKeyup.TabIndex = 10
        '
        'Bayar
        '
        Me.Bayar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bayar.AutoSize = True
        Me.Bayar.Location = New System.Drawing.Point(15, 250)
        Me.Bayar.Name = "Bayar"
        Me.Bayar.Size = New System.Drawing.Size(34, 13)
        Me.Bayar.TabIndex = 8
        Me.Bayar.Text = "Bayar"
        '
        'KeluaranTotalBayar
        '
        Me.KeluaranTotalBayar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeluaranTotalBayar.Enabled = False
        Me.KeluaranTotalBayar.Location = New System.Drawing.Point(15, 220)
        Me.KeluaranTotalBayar.Name = "KeluaranTotalBayar"
        Me.KeluaranTotalBayar.Size = New System.Drawing.Size(189, 20)
        Me.KeluaranTotalBayar.TabIndex = 7
        '
        'TotalBayar
        '
        Me.TotalBayar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalBayar.AutoSize = True
        Me.TotalBayar.Location = New System.Drawing.Point(15, 200)
        Me.TotalBayar.Name = "TotalBayar"
        Me.TotalBayar.Size = New System.Drawing.Size(61, 13)
        Me.TotalBayar.TabIndex = 6
        Me.TotalBayar.Text = "Total Bayar"
        '
        'DiskonKeyup
        '
        Me.DiskonKeyup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiskonKeyup.Location = New System.Drawing.Point(134, 170)
        Me.DiskonKeyup.Name = "DiskonKeyup"
        Me.DiskonKeyup.Size = New System.Drawing.Size(70, 20)
        Me.DiskonKeyup.TabIndex = 5
        '
        'DIskon
        '
        Me.DIskon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIskon.AutoSize = True
        Me.DIskon.Location = New System.Drawing.Point(134, 150)
        Me.DIskon.Name = "DIskon"
        Me.DIskon.Size = New System.Drawing.Size(57, 13)
        Me.DIskon.TabIndex = 4
        Me.DIskon.Text = "Diskon (%)"
        '
        'KeluaranJumlahBayar
        '
        Me.KeluaranJumlahBayar.Enabled = False
        Me.KeluaranJumlahBayar.Location = New System.Drawing.Point(15, 170)
        Me.KeluaranJumlahBayar.Name = "KeluaranJumlahBayar"
        Me.KeluaranJumlahBayar.Size = New System.Drawing.Size(115, 20)
        Me.KeluaranJumlahBayar.TabIndex = 3
        '
        'JumlahBayar
        '
        Me.JumlahBayar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JumlahBayar.AutoSize = True
        Me.JumlahBayar.Location = New System.Drawing.Point(15, 150)
        Me.JumlahBayar.Name = "JumlahBayar"
        Me.JumlahBayar.Size = New System.Drawing.Size(70, 13)
        Me.JumlahBayar.TabIndex = 2
        Me.JumlahBayar.Text = "Jumlah Bayar"
        '
        'KeluaranKeranjang
        '
        Me.KeluaranKeranjang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeluaranKeranjang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KeluaranKeranjang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.No, Me.KodeBarangKeranjang, Me.NamaBarangKeranjang, Me.Jumlah, Me.Harga, Me.SubTotal})
        Me.KeluaranKeranjang.HideSelection = False
        Me.KeluaranKeranjang.Location = New System.Drawing.Point(15, 35)
        Me.KeluaranKeranjang.Name = "KeluaranKeranjang"
        Me.KeluaranKeranjang.Size = New System.Drawing.Size(489, 100)
        Me.KeluaranKeranjang.TabIndex = 1
        Me.KeluaranKeranjang.TileSize = New System.Drawing.Size(1, 1)
        Me.KeluaranKeranjang.UseCompatibleStateImageBehavior = False
        Me.KeluaranKeranjang.View = System.Windows.Forms.View.Details
        '
        'No
        '
        Me.No.Text = "No"
        Me.No.Width = 30
        '
        'KodeBarangKeranjang
        '
        Me.KodeBarangKeranjang.Text = "Kode Barang"
        Me.KodeBarangKeranjang.Width = 85
        '
        'NamaBarangKeranjang
        '
        Me.NamaBarangKeranjang.Text = "Nama Barang"
        Me.NamaBarangKeranjang.Width = 150
        '
        'Jumlah
        '
        Me.Jumlah.Text = "Jumlah"
        Me.Jumlah.Width = 50
        '
        'Harga
        '
        Me.Harga.Text = "Harga"
        Me.Harga.Width = 70
        '
        'SubTotal
        '
        Me.SubTotal.Text = "SubTotal"
        Me.SubTotal.Width = 110
        '
        'Keranjang
        '
        Me.Keranjang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Keranjang.AutoSize = True
        Me.Keranjang.Location = New System.Drawing.Point(15, 10)
        Me.Keranjang.Name = "Keranjang"
        Me.Keranjang.Size = New System.Drawing.Size(95, 13)
        Me.Keranjang.TabIndex = 0
        Me.Keranjang.Text = "Keranjang Markisa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Kasir Markisa BDP"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.KeluaranGambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KapasitasKeranjangKeyUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasukanJumlahBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BayarKeyup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiskonKeyup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonMasukanKeranjang As Button
    Friend WithEvents KeluaranHargaBarang As TextBox
    Friend WithEvents HargaBarang As Label
    Friend WithEvents KeluaranNamaBarang As TextBox
    Friend WithEvents NamaBarang As Label
    Friend WithEvents KeluaranKodeBarang As TextBox
    Friend WithEvents KodeBarangAvailable As Label
    Friend WithEvents ButtonPeriksa As Button
    Friend WithEvents KodeBarang As Label
    Friend WithEvents MasukanKodeBarang As TextBox
    Friend WithEvents JumlahBarang As Label
    Friend WithEvents MasukanJumlahBarang As NumericUpDown
    Friend WithEvents KeluaranKeranjang As ListView
    Friend WithEvents No As ColumnHeader
    Friend WithEvents KodeBarangKeranjang As ColumnHeader
    Friend WithEvents NamaBarangKeranjang As ColumnHeader
    Friend WithEvents Jumlah As ColumnHeader
    Friend WithEvents Harga As ColumnHeader
    Friend WithEvents SubTotal As ColumnHeader
    Friend WithEvents Keranjang As Label
    Friend WithEvents KeluaranJumlahBayar As TextBox
    Friend WithEvents JumlahBayar As Label
    Friend WithEvents DIskon As Label
    Friend WithEvents DiskonKeyup As NumericUpDown
    Friend WithEvents KeluaranTotalBayar As TextBox
    Friend WithEvents TotalBayar As Label
    Friend WithEvents Bayar As Label
    Friend WithEvents BayarKeyup As NumericUpDown
    Friend WithEvents KeluaranKembali As TextBox
    Friend WithEvents Kembali As Label
    Friend WithEvents ButtonBayar As Button
    Friend WithEvents ButtonBersihkanKeranjang As Button
    Friend WithEvents PesanError2 As TextBox
    Friend WithEvents Nama As Label
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents PesanError As TextBox
    Friend WithEvents KapasitasKeranjangKeyUp As NumericUpDown
    Friend WithEvents KapasitasKeranjang As Label
    Friend WithEvents KeluaranGambar As PictureBox
    Friend WithEvents KeluaranStruk As RichTextBox
    Friend WithEvents ButtonCetak As Button
    Friend WithEvents KeluaranKapasitas As TextBox
    Friend WithEvents Kapasitas As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
