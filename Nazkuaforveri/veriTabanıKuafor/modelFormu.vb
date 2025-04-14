Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class modelFormu
    Private Sub BilgiSil()
        ModelAD.Clear()
        fyttb.Clear()
    End Sub
    Private Sub ARABTN_Click(sender As Object, e As EventArgs) Handles ARABTN.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from ModelBilgiTablosu where ModelAdi='" + ModelAD.Text + "'"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "ModelBilgiTablosu")
        DataGridView1.DataSource = dsv.Tables("ModelBilgiTablosu")
        BilgiSil()
        Connection.Close()

    End Sub

    Private Sub KAYDETBTN_Click(sender As Object, e As EventArgs) Handles KAYDETBTN.Click
        Dim connection As SqlConnection = New SqlConnection
        connection.ConnectionString = "Data Source=Localhost;Initial Catalog=kuaforVT;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.CommandText = "insert into ModelBilgiTablosu (ModelAdi,Fiyat) values('" + ModelAD.Text + "','" + fyttb.Text + "')"
        If Not String.IsNullOrEmpty(ModelAD.Text) AndAlso
  Not String.IsNullOrEmpty(fyttb.Text) Then
            MessageBox.Show("Boşluklar dolu!")
        Else
            MessageBox.Show("Lütfen tüm boşlukları doldurun!")
        End If
        SQLcommand.Connection = connection
        BilgiSil()
        SQLcommand.ExecuteNonQuery()

    End Sub

    Private Sub SİLBTN_Click(sender As Object, e As EventArgs) Handles SİLBTN.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=kuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "DELETE FROM ModelBilgiTablosu where ModelAdi ='" + ModelAD.Text + "'"
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from ModelBilgiTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "ModelBilgiTablosu")
        DataGridView1.DataSource = dsv.Tables("ModelBilgiTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub GUNCELLEBTN_Click(sender As Object, e As EventArgs) Handles GUNCELLEBTN.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "UPDATE ModelBilgiTablosu SET ModelAdi = '" + ModelAD.Text + "', Fiyat = '" + fyttb.Text + "' WHERE ModelAdi = '" + ModelAD.Text + "'"
        If Not String.IsNullOrEmpty(ModelAD.Text) AndAlso
  Not String.IsNullOrEmpty(fyttb.Text) Then
            MessageBox.Show("Boşluklar dolu!")
        Else
            MessageBox.Show("Lütfen tüm boşlukları doldurun!")
            End If

        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from ModelBilgiTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "ModelBilgiTablosu")
        DataGridView1.DataSource = dsv.Tables("ModelBilgiTablosu")
        BilgiSil()
        Connection.Close()
    End Sub

    Private Sub LISTELEBTN_Click(sender As Object, e As EventArgs) Handles LISTELEBTN.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=KuaforVT;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from ModelBilgiTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "ModelBilgiTablosu")
        DataGridView1.DataSource = dsv.Tables("ModelBilgiTablosu")
        BilgiSil()
        Connection.Close()
    End Sub
End Class