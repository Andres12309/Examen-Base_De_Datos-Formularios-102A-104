create table Usuarios(
	id_Usuario int identity(1,1) PRIMARY KEY,
	Ruc_Usuario varchar(20),
)
create table formulario_102A(
	id_Formulario int identity(1,1) PRIMARY KEY,
	id_Usuario int,

	-----encabezado----
	periodo varchar(50),
	NoEmpleados int,

	/*Ingresos*/
	i481 int,
	i718 int,
	i729 int, /*subtotal*/
	i741 int,

	/*Gastos deducibles*/
	g491 int,
	g739 int, /*subtotal*/
	g751 int,

	/*Renta imponible*/
	r749 int,	
	r759 int,
	r769 int,

	/*Otras deducciones y exoneraciones*/
	b740 varchar(25),

	/*Aplicable al período*/
	p768 int,
	p771 int,
	p772 int,
	p773 int,
	p774 int,
	p775 int,
	p779 int,
	p780 int, /*Total gastos personales*/


	/*Resumen impositivo*/
	c832 int,
	c839 float,
	c840 int,
	c845 int,
	c846 int,
	c855 float,/*subtotal impuesto a pagar*/
	c856 float,/*subtotal a favor*/
	c859 float,
	c869 float,
	FOREIGN KEY (id_Usuario) REFERENCES Usuarios(id_Usuario)
);

create table formulario106(
	id int identity(1,1),

	/*Encabezado*/
	c101 int,
	c102 int,

	/*Identificacion del sujeto pasivo*/
	c201 int,
	c202 varchar(50),
	c203 varchar(50),
	c204 varchar(50),
	c205 int,
	
	/*Identificacion de la obligacion*/
	c301 int,
	c302 varchar(50),
	c303 int,
	c304 int,
	c305 int,
	c306 int,
	
	/*Declaracion*/
	c198 int,
	c199 int,
	
	/*Valores a pagar y forma de pago*/
	c902 int,
	c903 int,
	c904 int,
	c999 int,
	c905 int,
	c906 int,
	c907 int,
	c925 int,

	/*Detalles*/
	c908 int,
	c909 int,
	c910 int,
	c911 int,
	c912 int,
	c913 int,
	c914 int,
	c915 int,
	c916 int,
	c917 int,
	c918 int,
	c919 int,
	c920 int
)

