Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Doctor")
        ComboBox1.Items.Add("Engineers")
        ComboBox1.Items.Add("Teachers")
        ComboBox1.Items.Add("Business Man")

        ComboBox2.Items.Add("Private Employee")
        ComboBox2.Items.Add("Junior Employee")

        ComboBox3.Items.Add("Day Labour")
        ComboBox3.Items.Add("Riskw Driver")
        ComboBox3.Items.Add("Bus/Truck Driver")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.SelectedIndex < 0 Then
            If ComboBox2.SelectedIndex < 0 Then
                If ComboBox3.SelectedIndex < 0 Then
                    MessageBox.Show("Please Select One Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            End If
        End If
        If ComboBox1.SelectedIndex > 0 Then
            If ComboBox2.SelectedIndex > 0 Then
                If ComboBox3.SelectedIndex > 0 Then
                    MessageBox.Show("Please Select Only One Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            End If
        End If
        If ComboBox1.SelectedIndex > 0 Then
            If ComboBox2.SelectedIndex > 0 Then
                    MessageBox.Show("Please Select Only One Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
        End If
        If ComboBox1.SelectedIndex > 0 Then
            If ComboBox3.SelectedIndex > 0 Then
                MessageBox.Show("Please Select Only One Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If
        If ComboBox2.SelectedIndex > 0 Then
            If ComboBox3.SelectedIndex > 0 Then
                MessageBox.Show("Please Select Only One Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If



        If TextBox1.Text = "" Then
            MessageBox.Show("Please Enter Your Income", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show("Please Enter Your Income In Digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim Income, output1, output2, output3 As Single
        Income = CSng(TextBox1.Text)
        output1 = Income * 0.3
        output2 = Income * 0.2
        output3 = Income * 0.1
        If ComboBox1.SelectedIndex = 0 Then
            Label6.Text = "You Select Category 1 (Doctor)" & vbCrLf & "Your Tax : " & output1
            Exit Sub
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Label6.Text = "You Select Category 1 (Engineers)" & vbCrLf & "Your Tax : " & output1
            Exit Sub
        End If
        If ComboBox1.SelectedIndex = 2 Then
            Label6.Text = "You Select Category 1 (Teachers)" & vbCrLf & "Your Tax : " & output1
            Exit Sub
        End If
        If ComboBox1.SelectedIndex = 3 Then
            Label6.Text = "You Select Category 1 (Business Man)" & vbCrLf & "Your Tax : " & output1
            Exit Sub
        End If

        If ComboBox2.SelectedIndex = 0 Then
            Label6.Text = "You Select Category 2 (Private Employee)" & vbCrLf & "Your Tax : " & output2
            Exit Sub
        End If
        If ComboBox2.SelectedIndex = 1 Then
            Label6.Text = "You Select Category 2 (Junior Employee)" & vbCrLf & "Your Tax : " & output2
            Exit Sub
        End If

        If ComboBox3.SelectedIndex = 0 Then
            Label6.Text = "You Select Category 3 (Day Labour)" & vbCrLf & "Your Tax : " & output3
            Exit Sub
        End If
        If ComboBox3.SelectedIndex = 1 Then
            Label6.Text = "You Select Category 3 (Riskw Driver)" & vbCrLf & "Your Tax : " & output3
            Exit Sub
        End If
        If ComboBox3.SelectedIndex = 2 Then
            Label6.Text = "You Select Category 3 (Bus/Truck Driver)" & vbCrLf & "Your Tax : " & output1
            Exit Sub
        End If
    End Sub
End Class
