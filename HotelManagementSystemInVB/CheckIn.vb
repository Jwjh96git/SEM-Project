Imports System.Data
Imports System.Data.SqlClient

Public Class CheckIn
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim getemp As String
    Dim dr As SqlDataReader
    Dim frm As New HotelManagementSystemInVB.ReusableCode



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm.OpenCon()
        frm.InsertSQL("insert into CheckInOut(id,name,mobile,nation,gender,city,state,check_in)values('" & TextBox1.Text & "','" & Label12.Text & "','" & Label13.Text & "','" & Label14.Text & "','" & Label15.Text & "','" & Label16.Text & "','" & Label17.Text & "','" & DateTimePicker1.Value.Date & "')")
        MsgBox("Check In Data inserted successfully..")
        Hide()
        frm.CloseCon()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        frm.OpenCon()
        Try
            dr = frm.SelectSQL("select name,mobile,nation,gender,city,state from customer where id='" & TextBox1.Text & "'")
            If dr.Read() Then
                Label12.Text = dr.GetValue(0).ToString()
                Label13.Text = dr.GetValue(1).ToString()
                Label14.Text = dr.GetValue(2).ToString()
                Label15.Text = dr.GetValue(3).ToString()
                Label16.Text = dr.GetValue(4).ToString()
                Label17.Text = dr.GetValue(5).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Value.ToString("dd/MM/yyy"))

        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Value.ToString("dd/MM/yyy"))

        Dim ts As TimeSpan = dt2.Subtract(dt1)
        frm.OpenCon()
        frm.InsertSQL(" update CheckInOut set check_out='" + DateTimePicker2.Value.Date + "',total_days='" + TextBox2.Text + "' where id= '" & TextBox1.Text & "'")
        MsgBox("Check Out Data updated successfully..")
        Hide()
        frm.CloseCon()
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim dt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Value.ToString("dd/MM/yyy"))

        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Value.ToString("dd/MM/yyy"))

        Dim ts As TimeSpan = dt2.Subtract(dt1)
        TextBox2.Text = Convert.ToInt32(ts.Days)
    End Sub
End Class