Imports System.Data.SqlClient

Partial Class _Default
    Inherits Page
    Public connect As New SqlConnection("Data Source=DELL-I7-05/SQLEXPRESS; Initial Catalog=CRUDTutorial_DB; User ID=DELL-I7-05\DELL-I7-05;")

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim productId As Integer = Integer.Parse(txtProductID.Text)
        Dim itemName As String = txtItemName.Text
        Dim specification As String = txtSpecification.Text
        Dim unit As String = dropUnit.SelectedValue
        Dim color As String = radioColor.SelectedValue
        Dim insertDate As DateTime = DateTime.Parse(txtDate.Text)
        Dim opening As Double = Double.Parse(txtOpeningQty.Text)
        Dim status As String = If(checkRegular.Checked, "Regular", "Irregular")

        Try
            connect.Open()
            Dim command As New SqlCommand("INSERT INTO ProductInfo_Tab (ProductID, ItemName, Specification, Uni, Color, InsertDate, Opening, Status) VALUES (@ProductID, @ItemName, @Specification, @Uni, @Color, @InsertDate, @Opening, @Status)", connect)
            command.Parameters.AddWithValue("@ProductID", productId)
            command.Parameters.AddWithValue("@ItemName", itemName)
            command.Parameters.AddWithValue("@Specification", specification)
            command.Parameters.AddWithValue("@Uni", unit)
            command.Parameters.AddWithValue("@Color", color)
            command.Parameters.AddWithValue("@InsertDate", insertDate)
            command.Parameters.AddWithValue("@Opening", opening)
            command.Parameters.AddWithValue("@Status", status)

            command.ExecuteNonQuery()
            MsgBox("Successfully Inserted", MsgBoxStyle.Information, "Message")
            ListProduct()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Message")
        Finally
            connect.Close()
        End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim productId As Integer = Integer.Parse(txtProductID.Text)
        Dim itemName As String = txtItemName.Text
        Dim specification As String = txtSpecification.Text
        Dim unit As String = dropUnit.SelectedValue
        Dim color As String = radioColor.SelectedValue
        Dim insertDate As DateTime = DateTime.Parse(txtDate.Text)
        Dim opening As Double = Double.Parse(txtOpeningQty.Text)
        Dim status As String = If(checkRegular.Checked, "Regular", "Irregular")

        Try
            connect.Open()
            Dim command As New SqlCommand("UPDATE ProductInfo_Tab SET ItemName = @ItemName, Specification = @Specification, Uni = @Uni, Color = @Color, InsertDate = @InsertDate, Opening = @Opening, Status = @Status WHERE ProductID = @ProductID", connect)
            command.Parameters.AddWithValue("@ProductID", productId)
            command.Parameters.AddWithValue("@ItemName", itemName)
            command.Parameters.AddWithValue("@Specification", specification)
            command.Parameters.AddWithValue("@Uni", unit)
            command.Parameters.AddWithValue("@Color", color)
            command.Parameters.AddWithValue("@InsertDate", insertDate)
            command.Parameters.AddWithValue("@Opening", opening)
            command.Parameters.AddWithValue("@Status", status)

            command.ExecuteNonQuery()
            MsgBox("Successfully Updated", MsgBoxStyle.Information, "Message")
            ListProduct()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Message")
        Finally
            connect.Close()
        End Try
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim productId As Integer = Integer.Parse(txtProductID.Text)

        Try
            connect.Open()
            Dim command As New SqlCommand("DELETE FROM ProductInfo_Tab WHERE ProductID = @ProductID", connect)
            command.Parameters.AddWithValue("@ProductID", productId)

            command.ExecuteNonQuery()
            MsgBox("Successfully Deleted", MsgBoxStyle.Information, "Message")
            ListProduct()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Message")
        Finally
            connect.Close()
        End Try
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim productId As Integer = Integer.Parse(txtProductID.Text)
        Dim command As New SqlCommand("SELECT * FROM ProductInfo_Tab WHERE ProductID = @ProductID", connect)
        command.Parameters.AddWithValue("@ProductID", productId)
        Dim sd As New SqlDataAdapter(command)
        Dim dt As New DataTable()

        Try
            connect.Open()
            sd.Fill(dt)
            GridView1.DataSource = dt
            GridView1.DataBind()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Message")
        Finally
            connect.Close()
        End Try
    End Sub

    Private Sub ListProduct()
        Dim command As New SqlCommand("SELECT * FROM ProductInfo_Tab", connect)
        Dim sd As New SqlDataAdapter(command)
        Dim dt As New DataTable()

        Try
            connect.Open()
            sd.Fill(dt)
            GridView1.DataSource = dt
            GridView1.DataBind()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Message")
        Finally
            connect.Close()
        End Try
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ListProduct()
        End If
    End Sub
End Class
