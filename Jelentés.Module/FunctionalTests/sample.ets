;#DropDB JelentésEasyTest

#Application JelentésWin
#Application JelentésWeb
#IfDef JelentésWin

*Action About...
 
*Action OK

#EndIf

#IfDef JelentésWeb
!Action Navigation(My Details)
#EndIf
