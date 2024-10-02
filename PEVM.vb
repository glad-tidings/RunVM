Public Class PEVM
    Protected Overrides Sub OnStart(ByVal args() As String)
        Dim myProcess As Process = New Process()
        myProcess.StartInfo.FileName = "C:\Program Files (x86)\VMware\VMware Workstation\vmrun.exe"
        myProcess.StartInfo.Arguments = "-T ws start ""C:\Users\Glad Tidings\Documents\Virtual Machines\PEVoip\PEVoip.vmx"""
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.Start()
        'Shell("vmrun -T ws start ""C:\Users\Glad Tidings\Documents\Virtual Machines\PEVoip\PEVoip.vmx""", AppWinStyle.Hide)
    End Sub

    Protected Overrides Sub OnStop()

    End Sub
End Class
