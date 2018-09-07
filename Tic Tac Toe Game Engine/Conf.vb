Public Class Conf

    Private Sub rdbBasicOn_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBasicOn.CheckedChanged
        If rdbBasicOn.Checked = True Then
            GUI.basicAI = True
        Else
            GUI.basicAI = False
        End If
    End Sub

    Private Sub rdbBasicOff_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBasicOff.CheckedChanged
        If rdbBasicOff.Checked = True Then
            GUI.basicAI = False
        Else
            GUI.basicAI = True
        End If
    End Sub

    Private Sub rdb9Inputs_CheckedChanged(sender As Object, e As EventArgs) Handles rdb9Inputs.CheckedChanged
        If rdb9Inputs.Checked = True Then
            GUI.keyLength = 9
        Else
            GUI.keyLength = 18
        End If
    End Sub

    Private Sub rdb18Inputs_CheckedChanged(sender As Object, e As EventArgs) Handles rdb18Inputs.CheckedChanged
        If rdb18Inputs.Checked = True Then
            GUI.keyLength = 18
        Else
            GUI.keyLength = 9
        End If
    End Sub

    Private Sub rdbAIO_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAIO.CheckedChanged
        If rdbAIO.Checked = True Then
            GUI.AIFirst = False
        Else
            GUI.AIFirst = True
        End If
    End Sub

    Private Sub rdbAIX_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAIX.CheckedChanged
        If rdbAIX.Checked = True Then
            GUI.AIFirst = True
        Else
            GUI.AIFirst = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        GUI.keyPath = txtKeyPath.Text
        GUI.vectorPath = txtVectorPath.Text
        GUI.vectorOutputPath = txtVectorOutputPath.Text
    End Sub

    Private Sub Conf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rdb9Inputs.Enabled = False
        rdb9Inputs.Checked = False
        rdb18Inputs.Enabled = False
        rdb18Inputs.Checked = True
        txtKeyPath.Text = GUI.keyPath
        txtVectorPath.Text = GUI.vectorPath
        txtVectorOutputPath.Text = GUI.vectorOutputPath

        If GUI.basicAI = True Then
            rdbBasicOn.Checked = True
            rdbBasicOff.Checked = False
        Else
            rdbBasicOn.Checked = False
            rdbBasicOff.Checked = True
        End If
        If GUI.advancedAI = True Then
            rdbKeyOn.Checked = True
            rdbKeyOff.Checked = False
        Else
            rdbKeyOn.Checked = False
            rdbKeyOff.Checked = True
        End If
        If GUI.AIFirst = True Then
            rdbAIX.Checked = True
            rdbAIO.Checked = False
        Else
            rdbAIX.Checked = False
            rdbAIO.Checked = True
        End If
        If GUI.vectorMode = True Then
            rdbVectorOn.Checked = True
            rdbVectorOff.Checked = False
            txtVectorPath.Enabled = True
            txtVectorOutputPath.Enabled = True
        Else
            rdbVectorOn.Checked = False
            rdbVectorOff.Checked = True
            txtVectorPath.Enabled = False
            txtVectorOutputPath.Enabled = False
        End If
    End Sub

    Private Sub rdbKeyOn_CheckedChanged(sender As Object, e As EventArgs) Handles rdbKeyOn.CheckedChanged
        If rdbKeyOn.Checked = True Then
            GUI.advancedAI = True
        Else
            GUI.advancedAI = False
        End If
    End Sub

    Private Sub rdbKeyOff_CheckedChanged(sender As Object, e As EventArgs) Handles rdbKeyOff.CheckedChanged
        If rdbKeyOff.Checked = True Then
            GUI.advancedAI = False
        Else
            GUI.advancedAI = True
        End If
    End Sub

    Private Sub rdbVectorOn_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVectorOn.CheckedChanged
        If rdbVectorOn.Checked = True Then
            GUI.vectorMode = True
            txtVectorPath.Enabled = True
            txtVectorOutputPath.Enabled = True
        Else
            GUI.vectorMode = False
            txtVectorPath.Enabled = False
            txtVectorOutputPath.Enabled = False
        End If
    End Sub

    Private Sub rdbVectorOff_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVectorOff.CheckedChanged
        If rdbVectorOff.Checked = True Then
            GUI.vectorMode = False
            txtVectorPath.Enabled = False
            txtVectorOutputPath.Enabled = False
        Else
            GUI.vectorMode = True
            txtVectorPath.Enabled = True
            txtVectorOutputPath.Enabled = True
        End If
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        GUI.initialize(True)
    End Sub
End Class