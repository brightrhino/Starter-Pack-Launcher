Public Class DFDirList

    Private Sub VersionListBox_DoubleClick() Handles VersionListBox.MouseDoubleClick
        FileWorking.DFDirListReturn = VersionListBox.FocusedItem.Index
        Me.Close()
    End Sub

End Class