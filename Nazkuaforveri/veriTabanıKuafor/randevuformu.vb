Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class randevuformu
    Private Sub BilgiSil()
        tcnotb.Clear()
    End Sub
    Private Sub ARABTN_Click(sender As Object, e As EventArgs) Handles ARABTN.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from RandevuTablosu where MusteriTC='" + tcnotb.Text + "'"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "RandevuTablosu")
        DataGridView1.DataSource = dsv.Tables("RandevuTablosu")
        BilgiSil()
        Connection.Close()

    End Sub

    Private Sub SİLBTN_Click(sender As Object, e As EventArgs) Handles SİLBTN.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=kuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "DELETE FROM RandevuTablosu where MusteriTC ='" + tcnotb.Text + "'"
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from RandevuTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "RandevuTablosu")
        DataGridView1.DataSource = dsv.Tables("RandevuTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub GUNCELLEME_Click(sender As Object, e As EventArgs) Handles GUNCELLEME.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "UPDATE RandevuTablosu SET RandevuSaati = '" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', MusteriTC = '" + tcnotb.Text + "' WHERE MusteriTC = '" + tcnotb.Text + "'"
        If Not String.IsNullOrEmpty(tcnotb.Text) Then
            MessageBox.Show("Boşluklar dolu!")
        Else
            MessageBox.Show("Lütfen tüm boşlukları doldurun!")
        End If
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from RandevuTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "RandevuTablosu")
        DataGridView1.DataSource = dsv.Tables("RandevuTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub LİSTBTN_Click(sender As Object, e As EventArgs) Handles LİSTBTN.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from RandevuTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "RandevuTablosu")
        DataGridView1.DataSource = dsv.Tables("RandevuTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub KAYDETBTN_Click(sender As Object, e As EventArgs) Handles KAYDETBTN.Click
        Dim connection As SqlConnection = New SqlConnection
        connection.ConnectionString = "Data Source=Localhost;Initial Catalog=kuaforVT;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.CommandText = "INSERT INTO RandevuTablosu (RandevuSaati, MusteriTC) VALUES ('" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'," + tcnotb.Text + ")"
        If Not String.IsNullOrEmpty(tcnotb.Text) Then
            MessageBox.Show("Boşluklar dolu!")
        Else
            MessageBox.Show("Lütfen tüm boşlukları doldurun!")
        End If
        SQLcommand.Connection = connection
        BilgiSil()
        SQLcommand.ExecuteNonQuery()
    End Sub

    'Private Sub randevuformu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: This line of code loads data into the 'KuaforVtDataSet1.RandevuTablosu' table. You can move, or remove it, as needed.
    '    Me.RandevuTablosuTableAdapter.Fill(Me.KuaforVtDataSet1.RandevuTablosu)

    'End Sub
End Class