Algoritmo Lecc17_Act3_Inc1
	Definir f,c,n,s Como Entero
	Definir t Como Entero
	Dimension t[4,3]
	
	Para f=1 Hasta 4 Hacer
		s=0
		Para c=1 Hasta 3 Hacer
			Escribir "Ingrese un numero"
			Leer n
			t[f,c]=n
			s=s+n
		FinPara
	Fin Para
	
	Escribir "La suma de la fila ", f," es: ',s
	
	
	
FinAlgoritmo
