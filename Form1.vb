Option Explicit On
'Option Strict On

Imports System.Drawing.Drawing2D
Imports System.IO

Public Class Form1


	Public ReadOnly DIR_Organizador As String = String.Concat(Application.StartupPath, "\Organizador")
	Public ReadOnly DIR_IMG As String = String.Concat(Application.StartupPath, "\Organizador\IMG")
	Public ReadOnly DIR_Log As String = String.Concat(Application.StartupPath, "\Organizador\Log.dat")
	Private LVItem As ListViewItem = New ListViewItem
	Public COLORR As Color = Color.White
	Private OldImageId As String = "0"
	Private ReadOnly Pass As String = "Fcaviglia"


	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Try
			ActiveControl = TXT_Clave
		Catch ex As Exception
			MsgBox("Form1_Load")
		End Try
	End Sub







	Private Sub ComprobarArchivos() Handles Me.Load
		Try
			If Not Directory.Exists(DIR_Organizador) Then Directory.CreateDirectory(DIR_Organizador)
			If Not Directory.Exists(DIR_IMG) Then Directory.CreateDirectory(DIR_IMG)
			If Not File.Exists(DIR_Log) Then File.Create(DIR_Log).Close()
			DeleteOldImages()
		Catch ex As Exception
			MsgBox("ComprobarArchivos")
		End Try
	End Sub

	Private Sub LV_CargarLV() Handles Me.Resize, Me.Load
		Try
			If LV_1.Columns.Count = 0 Then
				With LV_1
					.Columns.Add("PRODUCTO", 10, HorizontalAlignment.Center)
					.Columns.Add("PROVEEDOR", 10, HorizontalAlignment.Center)
					.Columns.Add("PRECIO VENTA", 10, HorizontalAlignment.Center)
					.Columns.Add("PRECIO COMPRA", 10, HorizontalAlignment.Center)
					.Columns.Add("PRECIO ENVÍO", 10, HorizontalAlignment.Center)
					.Columns.Add("PACK", 10, HorizontalAlignment.Center)
					.Columns.Add("GANANCIAS NETAS", 10, HorizontalAlignment.Center)
					.Columns.Add("% GANANCIAS", 10, HorizontalAlignment.Center)
					.Columns.Add("C", 0, HorizontalAlignment.Center)
					.Columns.Add("ID", 0, HorizontalAlignment.Center)
				End With
			End If

			With LV_1
				.Columns(0).Width = CInt(.Width / 8) - 1
				.Columns(1).Width = CInt(.Width / 8) - 1
				.Columns(2).Width = CInt(.Width / 8) - 1
				.Columns(3).Width = CInt(.Width / 8) - 1
				.Columns(4).Width = CInt(.Width / 8) - 1
				.Columns(5).Width = CInt(.Width / 8) - 1
				.Columns(6).Width = CInt(.Width / 8) - 1
				.Columns(7).Width = CInt(.Width / 8) - 1
				.Columns(8).Width = 0
				.Columns(9).Width = 0
			End With

			If LV_1.Columns.Count > 0 And LV_1.Items.Count = 0 Then GetItems()
		Catch ex As Exception
			MsgBox("LV_CargarLV")
		End Try
	End Sub

	Private Sub GetItems()
		Try
			If Not File.Exists(DIR_Log) Then Return

			Using MyStream As New StreamReader(DIR_Log)
				Do While MyStream.Peek <> -1
					Dim strTemp() = MyStream.ReadLine.Split(Chr(59))
					LV_1.Items.Add(LVItem)
					With LVItem
						.Text = strTemp(0).ToString
						.SubItems.Add(strTemp(1).ToString)
						.SubItems.Add(strTemp(2).ToString)
						.SubItems.Add(strTemp(3).ToString)
						.SubItems.Add(strTemp(4).ToString)
						.SubItems.Add(strTemp(5).ToString)
						.SubItems.Add(strTemp(6).ToString)
						.SubItems.Add(strTemp(7).ToString)
						.SubItems.Add(strTemp(8).ToString)
						.SubItems.Add(strTemp(9).ToString)

						If Len(strTemp(8).ToString) > 0 Then SetearColor(LVItem, Color.FromArgb(Integer.Parse(strTemp(8).ToString)))
					End With
					LVItem = New ListViewItem
				Loop
			End Using
			CargarCalculosGenerales()
		Catch ex As Exception
			MsgBox("GetItems")
		End Try
	End Sub

	Private Sub SetearColor(Item As ListViewItem, Colorr As Color)
		Try
			Item.ForeColor = Colorr
			Item.SubItems(8).Text = CStr(Colorr.ToArgb)
			AgregarRegistros()
		Catch ex As Exception
			MsgBox("SetearColor")
		End Try
	End Sub

	Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
		Try
			Me.Dispose()
		Catch ex As Exception
			MsgBox("BTN_Salir_Click")
		End Try
	End Sub

	Private Sub BTN_Cargar_Click(sender As Object, e As EventArgs) Handles BTN_Cargar.Click
		Try
			If Len(TXT_Producto.Text) = 0 Or Len(TXT_Proveedor.Text) = 0 Or Len(TXT_PrecioCompra.Text) = 0 Or Len(TXT_Envio.Text) = 0 Or Len(TXT_PorcVenta.Text) = 0 Or Len(TXT_Pack.Text) = 0 Then Return

			Dim PrecioDeVenta As Integer = CalcularPrecioVenta(CInt(TXT_PrecioCompra.Text), CInt(TXT_PorcVenta.Text), CInt(TXT_Pack.Text), CInt(TXT_Envio.Text), CInt(TXT_GA.Text))
			Dim GananciasNetasTotales As Integer = CalcularGananciasNetasTotales(CInt(TXT_PrecioCompra.Text), CInt(TXT_PorcVenta.Text), CInt(TXT_Pack.Text), CInt(TXT_Envio.Text), CInt(TXT_GA.Text))

			Padd(TXT_Producto.Text, TXT_Proveedor.Text, PrecioDeVenta, CInt(TXT_PrecioCompra.Text), CInt(TXT_Envio.Text), CInt(TXT_Pack.Text), GananciasNetasTotales, CInt(TXT_PorcVenta.Text), Color.White)
		Catch ex As Exception
			MsgBox("BTN_Cargar_Click")
		End Try
	End Sub

	Private Function CalcularPrecioVenta(PrecioTotalCompra As Integer, PorcVenta As Integer, PACK As Integer, PRECIOe As Integer, PRECIOa As Integer) As Integer
		Try
			Dim precioRealVenta As Integer = CInt(Math.Ceiling(((PrecioTotalCompra / PACK) * PorcVenta) / 100) + (PRECIOe / PACK) + PRECIOa)
			Return Math.Ceiling(precioRealVenta / 10) * 10
		Catch ex As Exception
			MsgBox("CalcularPrecioVenta")
			Return 0
		End Try
		Return 0
	End Function

	Private Function CalcularGananciasNetasTotales(PrecioTotalCompra As Integer, PorcVenta As Integer, PACK As Integer, PRECIOe As Integer, PRECIOa As Integer) As Integer
		Try
			Dim PrecioDeVenta As Integer = CInt(Math.Ceiling(((PrecioTotalCompra / PACK) * PorcVenta) / 100) + (PRECIOe / PACK) + PRECIOa)
			PrecioDeVenta = Math.Ceiling(PrecioDeVenta / 10) * 10
			Return CInt(Math.Round((PrecioDeVenta * PACK) - (PrecioTotalCompra + PRECIOe)))
		Catch ex As Exception
			MsgBox("CalcularGananciasN")
			Return 0
		End Try
		Return 0
	End Function

	Private Sub Padd(PRODUCTO As String, PROVEEDOR As String, Optional PrecioVentaUnitaria As Integer = 0, Optional PrecioTotalCompra As Integer = 0, Optional PrecioEnvio As Integer = 0, Optional PACK As Integer = 0, Optional GananciasNetasTotales As Integer = 0, Optional PorcVenta As Integer = 0, Optional Colorr As Color = Nothing)
		Try
			LVItem = New ListViewItem
			With LVItem
				.Text = PRODUCTO
				.SubItems.Add(PROVEEDOR)
				.SubItems.Add(Str(PrecioVentaUnitaria))
				.SubItems.Add(Str(PrecioTotalCompra))
				.SubItems.Add(Str(PrecioEnvio))
				.SubItems.Add(Str(PACK))
				.SubItems.Add(Str(GananciasNetasTotales))
				.SubItems.Add(Str(PorcVenta))
				If Colorr = Nothing Then .ForeColor = Color.White Else .ForeColor = CD_1.Color
				.SubItems.Add(Str(.ForeColor.ToArgb))
				.SubItems.Add("0")
			End With
			LV_1.Items.Add(LVItem)
			If LV_1.Items.Count > 2 Then LV_1.EnsureVisible(LV_1.Items.Count - 1)
			AgregarRegistros()
		Catch ex As Exception
			MsgBox("Padd")
		End Try
	End Sub

	Private Sub BTN_Borrar_Click(sender As Object, e As EventArgs) Handles BTN_Borrar.Click
		Try
			If LV_1.SelectedItems.Count = Nothing Then Return
			If LV_1.SelectedItems.Count = 0 Then Return
			LV_1.Items.Remove(LV_1.SelectedItems(0))
			AgregarRegistros()
		Catch ex As Exception
			MsgBox("BTN_Borrar_Click")
		End Try
	End Sub

	Private Sub BTN_BT_Click(sender As Object, e As EventArgs) Handles BTN_BT.Click
		Try
			If Not MsgBox("VAS A BORRAR TODO, SEGURA?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Return
			LV_1.Items.Clear()
			AgregarRegistros()
		Catch ex As Exception
			MsgBox("BTN_BT_Click")
		End Try
	End Sub

	Private Sub BTN_Color_Click(sender As Object, e As EventArgs) Handles BTN_Color.Click
		Try
			CD_1.ShowDialog()
			BTN_Color.BackColor = CD_1.Color
			PB_2.BackColor = CD_1.Color
		Catch ex As Exception
			MsgBox("BTN_Color_Click")
		End Try
	End Sub

	Public Sub AgregarRegistros()
		Try
			Using file As New IO.StreamWriter(DIR_Log, False)
				Dim line As String = ""
				For Each item As ListViewItem In Me.LV_1.Items
					line = ""
					For Each subitem As ListViewItem.ListViewSubItem In item.SubItems
						line += subitem.Text + ";" 'vbTab
					Next
					file.WriteLine(line)
				Next
				file.Close()
			End Using
			CargarCalculosGenerales()
			'Process.Start(filepath)
		Catch io As IOException
		Catch ex As Exception
			MsgBox("AgregarRegistro")
		End Try
	End Sub

	Public Sub SoloNumeros(sender As Object, e As KeyPressEventArgs)
		Try
			If e.KeyChar.IsDigit(e.KeyChar) Then
				e.Handled = False  ' introducción de dígitos 
			ElseIf e.KeyChar.IsLetter(e.KeyChar) Then
				e.Handled = True  ' introducción de letras
			ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
				e.Handled = True  ' introducción de espacios
			ElseIf e.KeyChar.IsControl(e.KeyChar) Then
				e.Handled = False
			Else
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message.ToString & vbCrLf & vbCrLf & vbCrLf & ex.StackTrace.ToString, MsgBoxStyle.OkOnly)
		End Try
	End Sub
	Public Sub SoloLetrasYespacios(sender As Object, e As KeyPressEventArgs)
		Try
			If e.KeyChar.IsDigit(e.KeyChar) Then
				e.Handled = True  ' introducción de dígitos
			ElseIf e.KeyChar.IsLetter(e.KeyChar) Then
				e.Handled = False  ' introducción de letras
			ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
				e.Handled = False  ' introducción de espacios
			ElseIf e.KeyChar.IsControl(e.KeyChar) Then
				e.Handled = False
			Else
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message.ToString & vbCrLf & vbCrLf & vbCrLf & ex.StackTrace.ToString, MsgBoxStyle.OkOnly)
		End Try
	End Sub
	Private Sub TXT_PrecioCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PrecioCompra.KeyPress
		SoloNumeros(sender, e)
	End Sub
	Private Sub TXT_Envio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Envio.KeyPress
		SoloNumeros(sender, e)
	End Sub
	Private Sub TXT_GA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_GA.KeyPress
		SoloNumeros(sender, e)
	End Sub
	Private Sub TXT_Pack_TextChanged(sender As Object, e As EventArgs) Handles TXT_Pack.KeyPress
		SoloNumeros(sender, e)
	End Sub
	Private Sub TXT_PorcVenta_TextChanged(sender As Object, e As EventArgs) Handles TXT_PorcVenta.KeyPress
		SoloNumeros(sender, e)
	End Sub

	Private Sub PB_1_Click(sender As Object, e As EventArgs) Handles PB_1.Click
		Try
			If LV_1.SelectedItems.Count <= 0 Then Return
			OpenImage()
		Catch ex As Exception
			MsgBox("BTN_Pintar_Click")
		End Try
	End Sub

	Public Sub OpenImage()
		Try
			'Set the Filter.
			OpenFD_1.Filter = "All Files|*.*"
			'Clear the file name
			OpenFD_1.FileName = ""
			'Show it
			If OpenFD_1.ShowDialog(Me) = DialogResult.OK Then
				PB_1.Image = Image.FromFile(OpenFD_1.FileName)
				SaveImage()
			End If
		Catch ex As Exception
			MsgBox("OpenImage")
		End Try
	End Sub

	Public Sub SaveImage()
		Try
			Dim IMGfile As String = String.Concat(DIR_IMG, "\", ChangeName(), ".jpg")
			Dim bmp As New Bitmap(PB_1.Image)
			bmp.Save(IMGfile, System.Drawing.Imaging.ImageFormat.Jpeg)
		Catch ex As Exception
			MsgBox("SaveImage")
		End Try
	End Sub

	Public Function ChangeName() As String
		Try
			Dim NewName As String = String.Concat(Now.Day, Now.Month, Now.Year, Now.Hour, Now.Minute, Now.Second, Now.Millisecond)
			OldImageId = LV_1.SelectedItems(0).SubItems(9).Text
			LV_1.SelectedItems(0).SubItems(9).Text = NewName
			AgregarRegistros()
			Return NewName
		Catch ex As Exception
			MsgBox("ChangeName")
			Return "Error"
		End Try
	End Function

	Public Sub DeleteOldImages()
		Try
			Dim IDs As List(Of String) = New List(Of String)
			For Each item As ListViewItem In Me.LV_1.Items
				IDs.Add(item.SubItems.Item(9).Text)
			Next

			Dim di As New IO.DirectoryInfo(DIR_IMG)
			Dim aryFi As IO.FileInfo() = di.GetFiles("*.jpg")
			Dim fi As IO.FileInfo
			For Each fi In aryFi
				IDs.Add(fi.Name.Replace(".jpg", "").Trim())
			Next

			Dim resultado = IDs.GroupBy(Function(x) x).Select(Function(y) New Resultados() With {
																									.Nombre = y.Key,
																									.Total = y.Count()})
			For Each res As Resultados In resultado
				If res.Total = 1 Then
					Dim IMGfile As String = String.Concat(DIR_IMG, "\", res.Nombre, ".jpg")
					If File.Exists(IMGfile) Then File.Delete(IMGfile)
				End If
			Next
		Catch ex As Exception
			MsgBox("DeleteActualImage")
		End Try
	End Sub

	Private Sub LV_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_1.SelectedIndexChanged
		Try
			If LV_1.SelectedItems.Count <= 0 Then Return
			Dim IMGfile As String = String.Concat(DIR_IMG, "\", LV_1.SelectedItems(0).SubItems(9).Text, ".jpg")
			If Not File.Exists(IMGfile) Then
				PB_1.Image = PB_1.InitialImage
				Return
			Else
				PB_1.Image = Image.FromFile(IMGfile)
			End If
		Catch ex As Exception
			MsgBox("LV_1_SelectedIndexChanged")
		End Try
	End Sub

	Private Sub PB_2_Click(sender As Object, e As EventArgs) Handles PB_2.Click
		Try
			If LV_1.SelectedItems.Count > 0 Then SetearColor(LV_1.SelectedItems(0), CD_1.Color)
		Catch ex As Exception
			MsgBox("BTN_Pintar_Click")
		End Try
	End Sub

	Private Sub CargarCalculosGenerales() Handles TXT_GA.TextChanged
		Try
			If LV_1.Items.Count <= 0 Then Return

			'Ganancias Netas Totales
			Dim AcGanancias As Integer = 0
			For Each item As ListViewItem In Me.LV_1.Items
				AcGanancias += CInt(item.SubItems.Item(6).Text)
			Next

			'Venta Total
			Dim AcVenta As Integer = 0
			For Each item As ListViewItem In Me.LV_1.Items
				AcVenta += (CInt(item.SubItems.Item(2).Text) * CInt(item.SubItems.Item(5).Text))
			Next

			'Unidades Compradas Total
			Dim AcUnidades As Integer = 0
			For Each item As ListViewItem In Me.LV_1.Items
				AcUnidades += CInt(item.SubItems.Item(5).Text)
			Next

			'Gastos Total
			Dim AcGastos As Integer = 0
			If Len(TXT_GA.Text) >= 1 Then AcGastos = AcUnidades * CInt(TXT_GA.Text) Else AcGastos = "0"

			TCT_Tganancias.Text = String.Concat("$ ", CStr(AcGanancias))
			TCT_Tventas.Text = String.Concat("$ ", CStr(AcVenta))
			TCT_UnidadesCompradas.Text = String.Concat(CStr(AcUnidades), "U")
			TCT_Tgastos.Text = String.Concat("$ ", CStr(AcGastos))
		Catch ex As Exception
			MsgBox("CargarCalculosGenerales")
		End Try
	End Sub

	Private Sub PB_2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PB_2.Paint
		Try
			Dim gp As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			gp.AddEllipse(0, 0, PB_2.Width - 1, PB_2.Height - 1)
			Dim rg As Region = New Region(gp)
			PB_2.Region = rg
		Catch ex As Exception
			MsgBox("PB_2_Paint")
		End Try
	End Sub

	Private Sub TXT_Clave_TextChanged(sender As Object, e As EventArgs) Handles TXT_Clave.TextChanged
		Try
			If TXT_Clave.Text.Equals(Pass) Then
				LV_1.Enabled = True
				GB_Datos.Enabled = True
			Else
				LV_1.Enabled = False
				GB_Datos.Enabled = False
			End If
		Catch ex As Exception
			MsgBox("TXT_Clave_TextChanged")
		End Try
	End Sub












End Class
