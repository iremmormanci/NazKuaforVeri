Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class personelformu
    Private Sub BilgiSil()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
    End Sub
    Private Sub KydtBtn_Click(sender As Object, e As EventArgs) Handles KydtBtn.Click
        Dim connection As SqlConnection = New SqlConnection
        connection.ConnectionString = "Data Source=Localhost;Initial Catalog=kuaforVT;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.CommandText = "insert into PersonelTablosu (PersonelTC, PersonelAdi, PersonelSoyadi, Telefon) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text +
         "','" + TextBox5.Text + "')"
        If Not String.IsNullOrEmpty(TextBox1.Text) AndAlso
  Not String.IsNullOrEmpty(TextBox2.Text) AndAlso
  Not String.IsNullOrEmpty(TextBox3.Text) AndAlso
  Not String.IsNullOrEmpty(TextBox5.Text) Then
            MessageBox.Show("Boşluklar dolu!")
        Else
            MessageBox.Show("Lütfen tüm boşlukları doldurun!")
        End If
        SQLcommand.Connection = connection
        BilgiSil()
        SQLcommand.ExecuteNonQuery()

    End Sub

    Private Sub arabtn_Click(sender As Object, e As EventArgs) Handles arabtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        'Dim sorgu = "Select * from PersonelTablosu where PersonelTC='" + TextBox1.Text + "'"
        Dim sorgu As String = "SELECT * FROM PersonelTablosu WHERE 1=1"
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            sorgu += " AND PersonelTC = '" + TextBox1.Text + "'"
        End If
        If Not String.IsNullOrEmpty(TextBox2.Text) Then
            sorgu += " AND PersonelAdi = '" + TextBox2.Text + "'"
        End If
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "PersonelTablosu")
        DataGridView1.DataSource = dsv.Tables("PersonelTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub siBtn_Click(sender As Object, e As EventArgs) Handles siBtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=kuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "DELETE FROM PersonelTablosu where PersonelTC ='" + TextBox1.Text + "'"
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from PersonelTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "PersonelTablosu")
        DataGridView1.DataSource = dsv.Tables("PersonelTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub GuncelleBtn_Click(sender As Object, e As EventArgs) Handles GuncelleBtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "UPDATE PersonelTablosu SET PersonelTC = '" + TextBox1.Text + "', PersonelAdi= '" + TextBox2.Text + "', PersonelSoyadi= '" + TextBox3.Text + "', Telefon= '" + TextBox1.Text + " ' WHERE PersonelTC = '" + TextBox1.Text + "'"
        If Not String.IsNullOrEmpty(TextBox1.Text) AndAlso
  Not String.IsNullOrEmpty(TextBox2.Text) AndAlso
  Not String.IsNullOrEmpty(TextBox3.Text) AndAlso
  Not String.IsNullOrEmpty(TextBox5.Text) Then
            MessageBox.Show("Boşluklar dolu!")
        Else
            MessageBox.Show("Lütfen tüm boşlukları doldurun!")
        End If
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from PersonelTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "PersonelTablosu")
        DataGridView1.DataSource = dsv.Tables("PersonelTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub listBtn_Click(sender As Object, e As EventArgs) Handles listBtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from PersonelTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "PersonelTablosu")
        DataGridView1.DataSource = dsv.Tables("PersonelTablosu")
        BilgiSil()
        Connection.Close()
    End Sub
End Class