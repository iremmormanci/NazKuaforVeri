Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class musteriformu
    Private Sub BilgiSil()
        telefon.Clear()
        musteriAd.Clear()
        musteriSoyad.Clear()
    End Sub
    Private Sub arabtn_Click(sender As Object, e As EventArgs) Handles arabtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from MusteriTablosu where Telefon='" + telefon.Text + "'"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "MusteriTablosu")
        DataGridView1.DataSource = dsv.Tables("MusteriTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub kydBtn_Click(sender As Object, e As EventArgs) Handles kydBtn.Click
        Dim connection As SqlConnection = New SqlConnection
        connection.ConnectionString = "Data Source=Localhost;Initial Catalog=kuaforVT;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.CommandText = "insert into MusteriTablosu (MusteriAdi, MusteriSoyadi, Telefon) values('" + musteriAd.Text + "','" + musteriSoyad.Text + "','" + telefon.Text + "')"
        If Not String.IsNullOrEmpty(musteriAd.Text) AndAlso
  Not String.IsNullOrEmpty(musteriSoyad.Text) AndAlso
  Not String.IsNullOrEmpty(telefon.Text) Then
            MessageBox.Show("Boşluklar dolu!")
        Else
            MessageBox.Show("Lütfen tüm boşlukları doldurun!")
        End If
        SQLcommand.Connection = connection
        BilgiSil()
        SQLcommand.ExecuteNonQuery()
    End Sub

    Private Sub silbtn_Click(sender As Object, e As EventArgs) Handles silbtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=kuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "DELETE FROM MusteriTablosu where Telefon ='" + telefon.Text + "'"
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from MusteriTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "MusteriTablosu")
        DataGridView1.DataSource = dsv.Tables("MusteriTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub guncellebtn_Click(sender As Object, e As EventArgs) Handles guncellebtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "UPDATE MusteriTablosu SET MusteriAdi = '" + musteriAd.Text + "', MusteriSoyadi= '" + musteriSoyad.Text + "', Telefon= '" + telefon.Text + " ' WHERE MusteriAdi = '" + musteriAd.Text + "'"
        If Not String.IsNullOrEmpty(musteriAd.Text) AndAlso
  Not String.IsNullOrEmpty(musteriSoyad.Text) AndAlso
  Not String.IsNullOrEmpty(telefon.Text) Then
            MessageBox.Show("Boşluklar dolu!")
        Else
            MessageBox.Show("Lütfen tüm boşlukları doldurun!")
        End If
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from MusteriTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "MusteriTablosu")
        DataGridView1.DataSource = dsv.Tables("MusteriTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub listbtn_Click(sender As Object, e As EventArgs) Handles listbtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from MusteriTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "MusteriTablosu")
        DataGridView1.DataSource = dsv.Tables("MusteriTablosu")
        BilgiSil()
        Connection.Close()
    End Sub
End Class