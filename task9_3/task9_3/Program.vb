Module Program
	Sub Main()
		'----------------------------9.3.1-------------------------
		For a=4 To 150 Step 4
			Console.WriteLine(a)
		Next a
		'---------------------------9.3.2---------------------------
		Dim UserName As String,flag As Boolean =False
		UserName=Console.ReadLine()
		For a=1 To UserName.Length() Step 1
			If Char.IsNumber(Mid(UserName,a,1)) Then
				flag=True
			End If
		Next a
		If  flag=True Then
			Console.WriteLine("please only enter letters")
		End If
		Console.ReadKey(True)
	End Sub
End Module
