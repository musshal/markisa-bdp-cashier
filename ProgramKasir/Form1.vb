Public Class Form1
    Dim dataBarang = {
        {"MK-102", "Buku Tulis Besar", "5000", "IMG_1904.JPG"},
        {"MK-162", "Buku Matematika Tebal", "8000", "IMG_1904.JPG"},
        {"MK-291", "Pulpen Tinta", "5000", "IMG_1905.JPG"},
        {"SH-27", "Pensil", "2500", "IMG_1908.PNG"},
        {"SH-41", "Sticky Note", "10000", "IMG_1922.JPG"},
        {"CD-33", "Sweater Polos", "39000", "IMG_1909.PNG"},
        {"CD-21", "Celana Linen Katun", "89000", "IMG_1910.JPG"},
        {"AF-76", "Vest", "52000", "IMG_1912.JPG"},
        {"AF-12", "Celana Kutot Jeans", "120000", "IMG_1915.JPG"},
        {"JK-58", "Kemeja Flanel", "87000", "IMG_1917.JPG"},
        {"JK_42", "Cardigan Jeno", "125000", "IMG_1923.JPG"},
        {"JK-14", "Cardigan Jaehyun", "135000", "IMG_1924.JPG"},
        {"KR-21", "Kerudung Pashmina Plisket", "25000", "IMG_1920.JPG"},
        {"KR-72", "Kerudung Paris Premium", "28000", "IMG1913.JPG"},
        {"CD-38", "Tote Bag Premium", "46000", "IMG_1918.JPG"}
    }

    Dim dataKeranjang(,) As String
    Dim hargaTemp As Integer
    Dim i As Integer = 0
    Dim index As Integer = -1
    Dim index2 As Integer
    Dim keranjangCounter As Integer
    Dim jumlahBayarTemp As Integer
    Dim totalBayarTemp As Integer
    Dim kembaliTemp As Integer

    Private Sub UploadData_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub KapasitasKeranjangKeyUp_ValueChanged(sender As Object, e As EventArgs) Handles KapasitasKeranjangKeyUp.ValueChanged
        ReDim dataKeranjang(KapasitasKeranjangKeyUp.Value, 7)
    End Sub

    Private Sub MasukanKodeBarang_TextChanged(sender As Object, e As EventArgs) Handles MasukanKodeBarang.TextChanged
        Dim suggestions As New AutoCompleteStringCollection
        Dim i As Integer
        Dim found As Boolean = False
        Dim id As String
        Dim strComputerName As String = Environment.UserName.ToString()
        Dim folder As String = $"C:\Users\{strComputerName}\OneDrive - Universitas Diponegoro\Pictures\Foto Produk Markisa BDP"
        Dim filename As String

        MasukanJumlahBarang.Value = 0

        For i = 0 To UBound(dataBarang)
            suggestions.Add(dataBarang(i, 0))

            If (MasukanKodeBarang.Text = dataBarang(i, 0)) Then
                found = True
            End If
        Next

        MasukanKodeBarang.AutoCompleteSource = AutoCompleteSource.CustomSource
        MasukanKodeBarang.AutoCompleteCustomSource = suggestions
        MasukanKodeBarang.AutoCompleteMode = AutoCompleteMode.Suggest

        If (found) Then
            PesanError.BackColor = Color.Green

            For i = 0 To UBound(dataBarang)
                If (MasukanKodeBarang.Text = dataBarang(i, 0)) Then
                    KeluaranKodeBarang.Text = dataBarang(i, 0)
                    KeluaranNamaBarang.Text = dataBarang(i, 1)
                    hargaTemp = Convert.ToInt32(dataBarang(i, 2))
                    KeluaranHargaBarang.Text = FormatCurrency(hargaTemp)
                    id = dataBarang(i, 3)
                    filename = System.IO.Path.Combine(folder, id)

                    Try
                        KeluaranGambar.Image = Image.FromFile(filename)
                    Catch ex As Exception
                        KeluaranGambar.Image = Nothing
                    End Try
                End If
            Next
        Else
            If (String.IsNullOrWhiteSpace(MasukanKodeBarang.Text)) Then
                PesanError.BackColor = Color.Empty

                KeluaranKodeBarang.Text = ""
                KeluaranNamaBarang.Text = ""
                KeluaranHargaBarang.Text = ""
                MasukanJumlahBarang.Text = ""
            Else
                PesanError.BackColor = Color.Red

                KeluaranKodeBarang.Text = ""
                KeluaranNamaBarang.Text = ""
                KeluaranHargaBarang.Text = ""
                MasukanJumlahBarang.Text = ""
            End If
        End If
    End Sub

    Private Sub ButtonPeriksa_Click(sender As Object, e As EventArgs) Handles ButtonPeriksa.Click
        Dim i As Integer
        Dim found As Boolean = False
        Dim id As String
        Dim strComputerName As String = Environment.UserName.ToString()
        Dim folder As String = $"C:\Users\{strComputerName}\OneDrive - Universitas Diponegoro\Pictures\Foto Produk Markisa BDP"
        Dim filename As String

        MasukanJumlahBarang.Value = 0

        For i = 0 To UBound(dataBarang)
            If (MasukanKodeBarang.Text = dataBarang(i, 0)) Then
                found = True
            End If
        Next

        If (found) Then
            For i = 0 To UBound(dataBarang)
                If (MasukanKodeBarang.Text = dataBarang(i, 0)) Then
                    KeluaranKodeBarang.Text = dataBarang(i, 0)
                    KeluaranNamaBarang.Text = dataBarang(i, 1)
                    hargaTemp = Convert.ToInt32(dataBarang(i, 2))
                    KeluaranHargaBarang.Text = FormatCurrency(hargaTemp)
                    id = dataBarang(i, 3)
                    filename = System.IO.Path.Combine(folder, id)

                    Try
                        KeluaranGambar.Image = Image.FromFile(filename)
                    Catch ex As Exception
                        KeluaranGambar.Image = Nothing
                    End Try

                End If
            Next
        Else
            PesanError.BackColor = Color.Red

            KeluaranKodeBarang.Text = ""
            KeluaranNamaBarang.Text = ""
            KeluaranHargaBarang.Text = ""
            MasukanJumlahBarang.Text = ""
        End If
    End Sub

    Private Sub ButtonMasukanKeranjang_Click(sender As Object, e As EventArgs) Handles ButtonMasukanKeranjang.Click
        Dim j As Integer
        Dim found As Boolean = False

        If (KapasitasKeranjangKeyUp.Value <= 0) Then
            MsgBox("Anda belum memasukan kapasitas keranjang!")
        ElseIf (String.IsNullOrWhiteSpace(KeluaranKodeBarang.Text)) Then
            MsgBox("Anda belum memasukan kode barang!")
        ElseIf (MasukanJumlahBarang.Value <= 0) Then
            MsgBox("Jumlah barang harus lebih dari 0!")
        ElseIf (MasukanJumlahBarang.Value > KapasitasKeranjangKeyUp.Value) Then
            MsgBox("Keranjang tidak muat!")
        Else
            If (Not String.IsNullOrWhiteSpace(KeluaranKodeBarang.Text)) Then
                KapasitasKeranjangKeyUp.Hide()
                KeluaranKapasitas.Text = KapasitasKeranjangKeyUp.Value

                If (keranjangCounter < UBound(dataKeranjang)) Then
                    If ((keranjangCounter + MasukanJumlahBarang.Value) <= KeluaranKapasitas.Text) Then
                        For j = 0 To UBound(dataKeranjang)
                            If (KeluaranKodeBarang.Text = dataKeranjang(j, 1)) Then
                                found = True
                                index2 = j
                            End If
                        Next

                        If (found) Then
                            dataKeranjang(index2, 3) = Convert.ToString(Convert.ToInt32(dataKeranjang(index2, 3)) + MasukanJumlahBarang.Value)
                            dataKeranjang(index2, 5) = Convert.ToString(Convert.ToInt32(dataKeranjang(index2, 3)) * Convert.ToInt32(hargaTemp))

                            KeluaranKeranjang.Items(index2).SubItems(3).Text = dataKeranjang(index2, 3)
                            KeluaranKeranjang.Items(index2).SubItems(5).Text = FormatCurrency(dataKeranjang(index2, 5))

                            jumlahBayarTemp += Convert.ToInt32(hargaTemp * MasukanJumlahBarang.Value)

                            index += 1
                            keranjangCounter += MasukanJumlahBarang.Value

                            found = False
                        Else
                            dataKeranjang(i, 0) = i + 1
                            dataKeranjang(i, 1) = KeluaranKodeBarang.Text
                            dataKeranjang(i, 2) = KeluaranNamaBarang.Text
                            dataKeranjang(i, 3) = MasukanJumlahBarang.Value
                            dataKeranjang(i, 4) = KeluaranHargaBarang.Text
                            dataKeranjang(i, 5) = Convert.ToString(MasukanJumlahBarang.Value * Convert.ToInt32(hargaTemp))

                            KeluaranKeranjang.Items.Add(dataKeranjang(i, 0))
                            KeluaranKeranjang.Items(i).SubItems.Add(dataKeranjang(i, 1))
                            KeluaranKeranjang.Items(i).SubItems.Add(dataKeranjang(i, 2))
                            KeluaranKeranjang.Items(i).SubItems.Add(dataKeranjang(i, 3))
                            KeluaranKeranjang.Items(i).SubItems.Add(dataKeranjang(i, 4))
                            KeluaranKeranjang.Items(i).SubItems.Add(FormatCurrency(dataKeranjang(i, 5)))

                            jumlahBayarTemp += Convert.ToInt32(dataKeranjang(i, 5))

                            index += 1
                            i += 1
                            keranjangCounter += MasukanJumlahBarang.Value
                        End If
                    Else
                        MsgBox("Keranjang tidak muat!")
                    End If
                Else
                    MsgBox("Keranjang penuh!")
                End If
            Else
                MsgBox("Anda belum melakukan masukan kode barang!")
            End If
        End If

        KeluaranJumlahBayar.Text = FormatCurrency(jumlahBayarTemp)
    End Sub

    Private Sub ButtonBersihkanKeranjang_Click(sender As Object, e As EventArgs) Handles ButtonBersihkanKeranjang.Click
        If (keranjangCounter > 0) Then
            If (MessageBox.Show("Apakah Anda yakin ingin membersihkan keranjang? ", "Info", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                KapasitasKeranjangKeyUp.Show()
                KeluaranKeranjang.Items.Clear()
                Array.Clear(dataKeranjang, 0, dataKeranjang.Length)
                i = 0
                index = -1
                index2 = 0
                KeluaranKapasitas.Text = ""
                keranjangCounter = 0
                jumlahBayarTemp = 0
                KeluaranJumlahBayar.Text = ""
                DiskonKeyup.Value = 0
                KeluaranTotalBayar.Text = ""
                BayarKeyup.Value = 0
                KeluaranKembali.Text = ""
                PesanError2.BackColor = Color.Empty
                PesanError2.Text = ""
            End If
        Else
            MsgBox("Keranjang kosong!")
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        If (Not String.IsNullOrWhiteSpace(KeluaranKodeBarang.Text)) Then
            If (MessageBox.Show("Apakah Anda yakin ingin membersihkan data barang? ", "Info", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                KeluaranKapasitas.Text = ""
                MasukanKodeBarang.Text = ""
                KeluaranKodeBarang.Text = ""
                KeluaranNamaBarang.Text = ""
                KeluaranHargaBarang.Text = ""
                MasukanJumlahBarang.Text = ""
                KeluaranGambar.Image = Nothing
            End If
        Else
            MsgBox("Data barang kosong!")
        End If
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        If (MessageBox.Show("Apakah Anda yakin ingin keluar? ", "Info", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            Close()
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles DiskonKeyup.ValueChanged
        totalBayarTemp = Convert.ToString(jumlahBayarTemp - jumlahBayarTemp * DiskonKeyup.Value / 100)
        KeluaranTotalBayar.Text = FormatCurrency(totalBayarTemp)
    End Sub

    Private Sub ButtonBayar_Click(sender As Object, e As EventArgs) Handles ButtonBayar.Click
        Dim i As Integer

        If (index <> -1) Then
            totalBayarTemp = Convert.ToString(jumlahBayarTemp - jumlahBayarTemp * DiskonKeyup.Value / 100)
            KeluaranTotalBayar.Text = FormatCurrency(totalBayarTemp)

            If (BayarKeyup.Value < Convert.ToInt32(totalBayarTemp)) Then
                MsgBox("Uang tidak mencukupi")
                PesanError2.Text = "TRANSAKSI GAGAL!"
                PesanError2.BackColor = Color.Red
            Else
                KeluaranStruk.Clear()

                kembaliTemp = BayarKeyup.Value - Convert.ToInt32(totalBayarTemp)
                KeluaranKembali.Text = FormatCurrency(kembaliTemp)
                PesanError2.Text = "TRANSAKSI BERHASIL!"
                PesanError2.BackColor = Color.Green

                If (Not String.IsNullOrWhiteSpace(dataKeranjang(i, 1))) Then
                    KeluaranStruk.AppendText("             MARKISA BDP")
                    KeluaranStruk.AppendText($"{Environment.NewLine}    SMK Bhakti Mulya Tangerang")
                    KeluaranStruk.AppendText($"{Environment.NewLine}Jl. KH. Hasyim Ashari Gg. Hj.Halimah")
                    KeluaranStruk.AppendText($"{Environment.NewLine}             Indonesia")
                    KeluaranStruk.AppendText($"{Environment.NewLine}           {Format(Date.Now(), "dd MMMM yyyy")}{Environment.NewLine}")
                    KeluaranStruk.AppendText($"{Environment.NewLine}------------------------------------")
                    KeluaranStruk.AppendText($"{Environment.NewLine}Nama Barang              Total Harga")
                    KeluaranStruk.AppendText($"{Environment.NewLine}------------------------------------{Environment.NewLine}")

                    For i = 0 To keranjangCounter - 1
                        If (Not String.IsNullOrWhiteSpace(dataKeranjang(i, 1))) Then
                            KeluaranStruk.AppendText($"{Environment.NewLine}{dataKeranjang(i, 2)}{Environment.NewLine}{dataKeranjang(i, 3)} x {FormatCurrency(dataKeranjang(i, 4))}            {FormatCurrency(dataKeranjang(i, 5))}{Environment.NewLine}")
                        End If
                    Next

                    KeluaranStruk.AppendText($"{Environment.NewLine}------------------------------------")
                    KeluaranStruk.AppendText($"{Environment.NewLine}Sub Total                {KeluaranJumlahBayar.Text}")
                    KeluaranStruk.AppendText($"{Environment.NewLine}Diskon                   {DiskonKeyup.Value}%")
                    KeluaranStruk.AppendText($"{Environment.NewLine}------------------------------------")
                    KeluaranStruk.AppendText($"{Environment.NewLine}Total                    {KeluaranTotalBayar.Text}")
                    KeluaranStruk.AppendText($"{Environment.NewLine}Bayar                    {FormatCurrency(BayarKeyup.Value)}")
                    KeluaranStruk.AppendText($"{Environment.NewLine}Kembali                  {KeluaranKembali.Text}{Environment.NewLine}")
                    KeluaranStruk.AppendText($"{Environment.NewLine}              | LUNAS |{Environment.NewLine}")
                    KeluaranStruk.AppendText($"{Environment.NewLine}------------------------------------")
                    KeluaranStruk.AppendText($"{Environment.NewLine}                 {Date.Now}{Environment.NewLine}")
                    KeluaranStruk.AppendText($"{Environment.NewLine}      -- TERIMA KASIH BESTIE --")
                End If
            End If
        Else
            MsgBox("Keranjang kosong!")
        End If
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        If (Not String.IsNullOrWhiteSpace(KeluaranStruk.Text)) Then
            If (MessageBox.Show("Apakah Anda yakin ingin membatalkan transaksi? ", "Info", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                KeluaranKembali.Text = ""
                PesanError2.Text = ""
                PesanError2.BackColor = Color.Empty
                KeluaranStruk.Clear()
            End If
        Else
            MsgBox("Belum ada transaksi!")
        End If
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        If (Not String.IsNullOrWhiteSpace(KeluaranStruk.Text)) Then
            SaveFileDialog1.Filter = "Txt Files(*.txt)|*.txt"
            SaveFileDialog1.FileName = $"markisa_receipt-{Format(Date.Now(), "dd-MM-yyyy-HH-mm-ss")}"

            If (SaveFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel) Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, KeluaranStruk.Text, True)
            End If
        Else
            MsgBox("Struk kosong!")
        End If
    End Sub
End Class
