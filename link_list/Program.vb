Module Program
	Public Structure node
		Dim data As String
		Dim nextp As Integer	
	End Structure
	Dim a(1000) As node
	Dim st As Integer=0,ed As Integer=0,cnt As Integer=0
	
	Function newnode(ByVal x As String) As Integer
		a(cnt).data=x
		a(cnt).nextp=-1
		cnt+=1
		Return cnt-1
	End Function
	
	Function insertAfter(ByVal x As String,byval str As String,byval pos As Integer) As Integer
		If Not a(pos).data=x Then
			insertAfter(x,str,a(pos).nextp)
			Return pos
		End If
		Dim tmp1 As Integer=newnode(str),tmp2=a(pos).nextp
		a(pos).nextp=tmp1
		a(tmp1).nextp=tmp2
		Return pos
	End Function
	
	Function append(ByVal x As String) As Integer
		If cnt=0 Then
			newnode(x)
			Return 0
		End If
		Dim tmp1 As Integer=newnode(x)
		a(ed).nextp=tmp1
		ed=tmp1
	End Function
	
	Function print(ByVal pos As Integer) As Boolean
		If Not pos=-1 Then
			Console.WriteLine(a(pos).data)
			print(a(pos).nextp)
		End If
	End Function
	
	Function deleteNode(ByVal x As String,ByVal pos As Integer) As Integer
		If Not a(a(pos).nextp).data=x Then
			deleteNode(x,a(pos).nextp)
			Return pos
		End If
		Dim tmp1=a(a(pos).nextp).nextp,tmp2=a(pos).nextp
		a(tmp2).nextp=-1
		a(pos).nextp=tmp1
		Return pos
	End Function
	
	Sub Main()
		append("AAA")
		append("BBB")
		append("CCC")
		append("DDD")
		insertAfter("BBB","B2C",st)
		deleteNode("BBB",st)
		print(st)
		Console.ReadKey(True)
	End Sub
End Module
