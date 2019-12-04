Module Program
	Sub Main()
		Const maxn As Integer=100
		Dim arr(maxn) As Integer,n As Integer, t As Integer, pos As Integer, tmp As Integer
		n=Console.ReadLine()
		For i As Integer = 1 To n
			arr(i)=Console.ReadLine()
		Next i
		t=n
		For i As Integer = 1 To n
			For j As Integer = 1 To t-1
				If arr(j)>arr(j+1) Then
					tmp=arr(j)
					arr(j)=arr(j+1)
					arr(j+1)=tmp
					pos=j
				End If
			Next j
			t=pos
		Next i
		For i As Integer = 1 To n
			Console.Write(arr(i) & " ")
		Next i
		Console.ReadKey(True)
	End Sub
End Module
