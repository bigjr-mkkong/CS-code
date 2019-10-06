Module Program
	Dim n%,m%,root%,l%,r%,p%,cnt%
	Public structure node
	Dim l%,r%,size%,val%,rev%,imp%
	End Structure
	Dim tree(100) As node,rand As New Random
	
	Sub adde(x%)
		Randomize
		tree(x).val=x
		tree(x).size=1
		tree(x).imp=Rnd*100
		tree(x).l=0
		tree(x).r=0
	End Sub
	
	Sub swap(ByRef a%,ByRef b%)
		Dim tmp=a
		a=b
		b=tmp
	End Sub
	
	Sub pushdown(u%)
		swap(tree(u).l,tree(u).r)
		tree(tree(u).l).rev =tree(tree(u).l).rev xor 1
		tree(tree(u).r).rev =tree(tree(u).r).rev Xor 1
		tree(u).rev=0
	End Sub
	
	Sub update(u%)
		tree(u).size=tree(tree(u).l).size+tree(Int(tree(u).r)).size+1
	End Sub
	
	Sub split(u%,x%,ByRef l%,ByRef r%)
		If (u=0) Then
			l=0
			r=0
			Exit Sub
		End If
		If tree(u).rev <> 0 Then
			pushdown(u) 
		End If
		If tree(tree(u).l).size+1 <= x Then
			l=u
			split(tree(u).r,x-tree(tree(u).l).size-1,tree(u).r,r)
		Else
			r=u
        	split(tree(u).l,x,l,tree(u).l)
		End If
		update(u)
	End Sub
	
	Public Function merge(l%,r%) As Integer
		If l=0 Or r=0 Then
			return l+r
		End If
		If tree(l).imp<tree(r).imp Then
			If tree(l).rev <> 0 Then
				pushdown(l)
			End If
			tree(l).r=merge(tree(l).r,r)
			update(l)
			Return l
		Else
			If tree(r).rev <> 0 Then
				pushdown(r)
			End If
			tree(r).l=merge(l,tree(r).l)
			update(r)
			Return r
		End If
	End Function
	
	Sub printans(u%)
		If tree(u).rev <> 0 Then
			pushdown(u)
		End If
		If tree(u).l <> 0 Then 
			printans(tree(u).l)
		End If
		Console.Write(Str(tree(u).val) & " ")
		If tree(u).r <> 0Then
			printans(tree(u).r)
		End If
	End Sub
	
	Sub Main()
		n=Console.ReadLine()
		m=Console.ReadLine()
		For i As Integer = 1 To n
			adde(i)
			root=merge(root,i)
		Next i
		Dim x%,y%
		For i As Integer = 1 To m
			x=Console.ReadLine()
			y=Console.ReadLine()
			split(root,y,l,r)
			split(l,x-1,l,p)
			tree(p).rev=tree(p).rev Xor 1
			root=merge(merge(l,p),r)
		Next i
		printans(root)
		Console.ReadKey(True)
	End Sub
End Module
