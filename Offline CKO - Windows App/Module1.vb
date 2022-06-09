Module Module1
    Public DueDate As DateTime
    Public PrinterToUse As String
    Public FilePath As String
    Public FilePathNoCard As String
    Public NoCard As Boolean
    Public PatronName As String
    Public PatronDOB As String
    Public PatronPhone As String
    Public PatronNotes As String

    Public GS As String = Chr(&H1D)
    Public ESC As String = Chr(&H1B)
    Public LF As String = Chr(&HA)
    Public PrintString As String
    Public PresetDateChosen As Boolean

End Module
