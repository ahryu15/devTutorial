;#DropDB devTutorialEasyTest

#Application devTutorialWin
#Application devTutorialWeb
#IfDef devTutorialWin

*Action About...
 
*Action OK

#EndIf

#IfDef devTutorialWeb
*Action Navigation(My Details)
#EndIf
