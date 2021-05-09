<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.namaCst_Lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkoutBtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MainCourseTab = New System.Windows.Forms.TabPage()
        Me.ListMainCourse = New System.Windows.Forms.ListView()
        Me.SideDishTab = New System.Windows.Forms.TabPage()
        Me.ListSideDish = New System.Windows.Forms.ListView()
        Me.DrinksTab = New System.Windows.Forms.TabPage()
        Me.ListDrinks = New System.Windows.Forms.ListView()
        Me.DessertTab = New System.Windows.Forms.TabPage()
        Me.ListDessert = New System.Windows.Forms.ListView()
        Me.ListPesanan = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.kategoriLbl = New System.Windows.Forms.Label()
        Me.jmlBox = New System.Windows.Forms.NumericUpDown()
        Me.tambahBtn = New System.Windows.Forms.Button()
        Me.totalHargaBox = New System.Windows.Forms.TextBox()
        Me.hargaMenuBox = New System.Windows.Forms.TextBox()
        Me.namaMenuBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.ubahBtn = New System.Windows.Forms.Button()
        Me.jmlPesanan = New System.Windows.Forms.NumericUpDown()
        Me.totalHargaPesanan = New System.Windows.Forms.TextBox()
        Me.hargaPesananBox = New System.Windows.Forms.TextBox()
        Me.namaPesananBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TabControl1.SuspendLayout()
        Me.MainCourseTab.SuspendLayout()
        Me.SideDishTab.SuspendLayout()
        Me.DrinksTab.SuspendLayout()
        Me.DessertTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.jmlBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.jmlPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'namaCst_Lbl
        '
        Me.namaCst_Lbl.AutoSize = True
        Me.namaCst_Lbl.Location = New System.Drawing.Point(12, 9)
        Me.namaCst_Lbl.Name = "namaCst_Lbl"
        Me.namaCst_Lbl.Size = New System.Drawing.Size(124, 20)
        Me.namaCst_Lbl.TabIndex = 0
        Me.namaCst_Lbl.Text = "Nama Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(414, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Pesanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Harga"
        '
        'checkoutBtn
        '
        Me.checkoutBtn.Location = New System.Drawing.Point(521, 686)
        Me.checkoutBtn.Name = "checkoutBtn"
        Me.checkoutBtn.Size = New System.Drawing.Size(122, 59)
        Me.checkoutBtn.TabIndex = 3
        Me.checkoutBtn.Text = "Checkout"
        Me.checkoutBtn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.MainCourseTab)
        Me.TabControl1.Controls.Add(Me.SideDishTab)
        Me.TabControl1.Controls.Add(Me.DrinksTab)
        Me.TabControl1.Controls.Add(Me.DessertTab)
        Me.TabControl1.ItemSize = New System.Drawing.Size(139, 25)
        Me.TabControl1.Location = New System.Drawing.Point(6, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(692, 256)
        Me.TabControl1.TabIndex = 4
        '
        'MainCourseTab
        '
        Me.MainCourseTab.Controls.Add(Me.ListMainCourse)
        Me.MainCourseTab.Location = New System.Drawing.Point(4, 29)
        Me.MainCourseTab.Margin = New System.Windows.Forms.Padding(0)
        Me.MainCourseTab.Name = "MainCourseTab"
        Me.MainCourseTab.Size = New System.Drawing.Size(684, 223)
        Me.MainCourseTab.TabIndex = 0
        Me.MainCourseTab.Text = "Main Course"
        Me.MainCourseTab.UseVisualStyleBackColor = True
        '
        'ListMainCourse
        '
        Me.ListMainCourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListMainCourse.FullRowSelect = True
        Me.ListMainCourse.GridLines = True
        Me.ListMainCourse.HideSelection = False
        Me.ListMainCourse.HoverSelection = True
        Me.ListMainCourse.Location = New System.Drawing.Point(0, 0)
        Me.ListMainCourse.Name = "ListMainCourse"
        Me.ListMainCourse.Size = New System.Drawing.Size(684, 223)
        Me.ListMainCourse.TabIndex = 0
        Me.ListMainCourse.UseCompatibleStateImageBehavior = False
        Me.ListMainCourse.View = System.Windows.Forms.View.Details
        '
        'SideDishTab
        '
        Me.SideDishTab.Controls.Add(Me.ListSideDish)
        Me.SideDishTab.Location = New System.Drawing.Point(4, 29)
        Me.SideDishTab.Margin = New System.Windows.Forms.Padding(0)
        Me.SideDishTab.Name = "SideDishTab"
        Me.SideDishTab.Size = New System.Drawing.Size(684, 223)
        Me.SideDishTab.TabIndex = 1
        Me.SideDishTab.Text = "Side Dish"
        Me.SideDishTab.UseVisualStyleBackColor = True
        '
        'ListSideDish
        '
        Me.ListSideDish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListSideDish.FullRowSelect = True
        Me.ListSideDish.GridLines = True
        Me.ListSideDish.HideSelection = False
        Me.ListSideDish.Location = New System.Drawing.Point(0, 0)
        Me.ListSideDish.Name = "ListSideDish"
        Me.ListSideDish.Size = New System.Drawing.Size(684, 223)
        Me.ListSideDish.TabIndex = 0
        Me.ListSideDish.UseCompatibleStateImageBehavior = False
        Me.ListSideDish.View = System.Windows.Forms.View.Details
        '
        'DrinksTab
        '
        Me.DrinksTab.Controls.Add(Me.ListDrinks)
        Me.DrinksTab.Location = New System.Drawing.Point(4, 29)
        Me.DrinksTab.Margin = New System.Windows.Forms.Padding(0)
        Me.DrinksTab.Name = "DrinksTab"
        Me.DrinksTab.Size = New System.Drawing.Size(684, 223)
        Me.DrinksTab.TabIndex = 2
        Me.DrinksTab.Text = "Drinks"
        Me.DrinksTab.UseVisualStyleBackColor = True
        '
        'ListDrinks
        '
        Me.ListDrinks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListDrinks.FullRowSelect = True
        Me.ListDrinks.GridLines = True
        Me.ListDrinks.HideSelection = False
        Me.ListDrinks.Location = New System.Drawing.Point(0, 0)
        Me.ListDrinks.Name = "ListDrinks"
        Me.ListDrinks.Size = New System.Drawing.Size(684, 223)
        Me.ListDrinks.TabIndex = 0
        Me.ListDrinks.UseCompatibleStateImageBehavior = False
        Me.ListDrinks.View = System.Windows.Forms.View.Details
        '
        'DessertTab
        '
        Me.DessertTab.Controls.Add(Me.ListDessert)
        Me.DessertTab.Location = New System.Drawing.Point(4, 29)
        Me.DessertTab.Margin = New System.Windows.Forms.Padding(0)
        Me.DessertTab.Name = "DessertTab"
        Me.DessertTab.Size = New System.Drawing.Size(684, 223)
        Me.DessertTab.TabIndex = 3
        Me.DessertTab.Text = "Dessert"
        Me.DessertTab.UseVisualStyleBackColor = True
        '
        'ListDessert
        '
        Me.ListDessert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListDessert.FullRowSelect = True
        Me.ListDessert.GridLines = True
        Me.ListDessert.HideSelection = False
        Me.ListDessert.Location = New System.Drawing.Point(0, 0)
        Me.ListDessert.Name = "ListDessert"
        Me.ListDessert.Size = New System.Drawing.Size(684, 223)
        Me.ListDessert.TabIndex = 0
        Me.ListDessert.UseCompatibleStateImageBehavior = False
        Me.ListDessert.View = System.Windows.Forms.View.Details
        '
        'ListPesanan
        '
        Me.ListPesanan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader2})
        Me.ListPesanan.FullRowSelect = True
        Me.ListPesanan.GridLines = True
        Me.ListPesanan.HideSelection = False
        Me.ListPesanan.Location = New System.Drawing.Point(10, 25)
        Me.ListPesanan.Name = "ListPesanan"
        Me.ListPesanan.Size = New System.Drawing.Size(688, 225)
        Me.ListPesanan.TabIndex = 5
        Me.ListPesanan.UseCompatibleStateImageBehavior = False
        Me.ListPesanan.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Nama Produk"
        Me.ColumnHeader13.Width = 120
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Kategori"
        Me.ColumnHeader14.Width = 80
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Jumlah"
        Me.ColumnHeader15.Width = 68
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Harga"
        Me.ColumnHeader16.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Total"
        Me.ColumnHeader2.Width = 100
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.kategoriLbl)
        Me.GroupBox1.Controls.Add(Me.jmlBox)
        Me.GroupBox1.Controls.Add(Me.tambahBtn)
        Me.GroupBox1.Controls.Add(Me.totalHargaBox)
        Me.GroupBox1.Controls.Add(Me.hargaMenuBox)
        Me.GroupBox1.Controls.Add(Me.namaMenuBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1042, 287)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'kategoriLbl
        '
        Me.kategoriLbl.AutoSize = True
        Me.kategoriLbl.Location = New System.Drawing.Point(754, 199)
        Me.kategoriLbl.Name = "kategoriLbl"
        Me.kategoriLbl.Size = New System.Drawing.Size(57, 20)
        Me.kategoriLbl.TabIndex = 8
        Me.kategoriLbl.Text = "Label1"
        Me.kategoriLbl.Visible = False
        '
        'jmlBox
        '
        Me.jmlBox.Location = New System.Drawing.Point(936, 127)
        Me.jmlBox.Name = "jmlBox"
        Me.jmlBox.Size = New System.Drawing.Size(100, 26)
        Me.jmlBox.TabIndex = 6
        Me.jmlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tambahBtn
        '
        Me.tambahBtn.Location = New System.Drawing.Point(831, 230)
        Me.tambahBtn.Name = "tambahBtn"
        Me.tambahBtn.Size = New System.Drawing.Size(107, 47)
        Me.tambahBtn.TabIndex = 7
        Me.tambahBtn.Text = "Tambah"
        Me.tambahBtn.UseVisualStyleBackColor = True
        '
        'totalHargaBox
        '
        Me.totalHargaBox.Location = New System.Drawing.Point(936, 159)
        Me.totalHargaBox.Name = "totalHargaBox"
        Me.totalHargaBox.ReadOnly = True
        Me.totalHargaBox.Size = New System.Drawing.Size(100, 26)
        Me.totalHargaBox.TabIndex = 2
        '
        'hargaMenuBox
        '
        Me.hargaMenuBox.Location = New System.Drawing.Point(936, 82)
        Me.hargaMenuBox.Name = "hargaMenuBox"
        Me.hargaMenuBox.ReadOnly = True
        Me.hargaMenuBox.Size = New System.Drawing.Size(100, 26)
        Me.hargaMenuBox.TabIndex = 5
        '
        'namaMenuBox
        '
        Me.namaMenuBox.Location = New System.Drawing.Point(936, 36)
        Me.namaMenuBox.Name = "namaMenuBox"
        Me.namaMenuBox.ReadOnly = True
        Me.namaMenuBox.Size = New System.Drawing.Size(100, 26)
        Me.namaMenuBox.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(751, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(751, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(751, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(751, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(749, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(747, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Rp. "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deleteBtn)
        Me.GroupBox2.Controls.Add(Me.ubahBtn)
        Me.GroupBox2.Controls.Add(Me.jmlPesanan)
        Me.GroupBox2.Controls.Add(Me.totalHargaPesanan)
        Me.GroupBox2.Controls.Add(Me.hargaPesananBox)
        Me.GroupBox2.Controls.Add(Me.ListPesanan)
        Me.GroupBox2.Controls.Add(Me.namaPesananBox)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 424)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1042, 256)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pesanan"
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(909, 203)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(98, 47)
        Me.deleteBtn.TabIndex = 9
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'ubahBtn
        '
        Me.ubahBtn.Location = New System.Drawing.Point(774, 203)
        Me.ubahBtn.Name = "ubahBtn"
        Me.ubahBtn.Size = New System.Drawing.Size(98, 47)
        Me.ubahBtn.TabIndex = 8
        Me.ubahBtn.Text = "Ubah"
        Me.ubahBtn.UseVisualStyleBackColor = True
        '
        'jmlPesanan
        '
        Me.jmlPesanan.Location = New System.Drawing.Point(932, 105)
        Me.jmlPesanan.Name = "jmlPesanan"
        Me.jmlPesanan.Size = New System.Drawing.Size(98, 26)
        Me.jmlPesanan.TabIndex = 7
        '
        'totalHargaPesanan
        '
        Me.totalHargaPesanan.Location = New System.Drawing.Point(930, 146)
        Me.totalHargaPesanan.Name = "totalHargaPesanan"
        Me.totalHargaPesanan.ReadOnly = True
        Me.totalHargaPesanan.Size = New System.Drawing.Size(100, 26)
        Me.totalHargaPesanan.TabIndex = 6
        '
        'hargaPesananBox
        '
        Me.hargaPesananBox.Location = New System.Drawing.Point(930, 67)
        Me.hargaPesananBox.Name = "hargaPesananBox"
        Me.hargaPesananBox.ReadOnly = True
        Me.hargaPesananBox.Size = New System.Drawing.Size(100, 26)
        Me.hargaPesananBox.TabIndex = 5
        '
        'namaPesananBox
        '
        Me.namaPesananBox.Location = New System.Drawing.Point(930, 28)
        Me.namaPesananBox.Name = "namaPesananBox"
        Me.namaPesananBox.ReadOnly = True
        Me.namaPesananBox.Size = New System.Drawing.Size(100, 26)
        Me.namaPesananBox.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(751, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 20)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(747, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Jumlah"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(751, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Harga"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(751, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nama"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(791, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "0"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 40)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(329, 20)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Sudah punya Akun ? Login, dapatkan diskon!"
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1145, 753)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.checkoutBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.namaCst_Lbl)
        Me.Name = "mainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainWindow"
        Me.TabControl1.ResumeLayout(False)
        Me.MainCourseTab.ResumeLayout(False)
        Me.SideDishTab.ResumeLayout(False)
        Me.DrinksTab.ResumeLayout(False)
        Me.DessertTab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.jmlBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.jmlPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents namaCst_Lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents checkoutBtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents MainCourseTab As TabPage
    Friend WithEvents ListMainCourse As ListView
    Friend WithEvents SideDishTab As TabPage
    Friend WithEvents ListPesanan As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents totalHargaBox As TextBox
    Friend WithEvents hargaMenuBox As TextBox
    Friend WithEvents namaMenuBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tambahBtn As Button
    Friend WithEvents DrinksTab As TabPage
    Friend WithEvents DessertTab As TabPage
    Friend WithEvents jmlBox As NumericUpDown
    Friend WithEvents ListDrinks As ListView
    Friend WithEvents ListDessert As ListView
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents deleteBtn As Button
    Friend WithEvents ubahBtn As Button
    Friend WithEvents jmlPesanan As NumericUpDown
    Friend WithEvents totalHargaPesanan As TextBox
    Friend WithEvents hargaPesananBox As TextBox
    Friend WithEvents namaPesananBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ListSideDish As ListView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents kategoriLbl As Label
End Class
