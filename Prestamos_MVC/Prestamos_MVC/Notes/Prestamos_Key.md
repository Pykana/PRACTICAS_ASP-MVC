# MODO DE ENCRIPTAMIENTO
==========================

## 	METODO

		DATO INTRODUCIDO serverName (MINIMO 10 PALABRAS)			+
		PRIMEROS DOS NUMEROS DE portNumber(4 MINIMO)				+
		DATO INTRODUCIDO databaseName (MINIMO 5 PALABRAS)			+
		ULTIMOS DOS NUMEROS DE portNumber(4 MINIMO)					+
		DATO INTRODUCIDO userName (MINIMO 2 PALABRAS)				+
		DATO INTRODUCIDO passswordUser (MINIMO 2 PALABRAS)			+
		DATO INTRODUCIDO TrustedConnection (SOLO 1 PALABRA = 0 o 1)	+
		DATO INTRODUCIDO TypeDeployment (MINIMO 3 PALABRA)		


# CREACION DE ARCHIVO XML
==========================

## LLAVE PREDETERMINADA 
			&U9tU6TjPM63G4A*pdee4nta*Fzws4FBGX^iwpD93Depsq7rMNX2Y#6@iEWthhznc!yMUrU7kQ$hVf97NCUwm5AxFj$@YGeiR5Kc&nRdca@o32#3iHCbmatUmdusLH5b


# ESTRUCTURA DE LA BASE DE DATOS - RELACIONES  - Prestamos_Key
==========================

		ES UNA UNICA TABLA

# BASE DE DATOS	-  Prestamos_Key
==========================

## TABLAS
### KeyConnect
		CREATE TABLE KeyConnect(
			idKey int primary key not null identity,
			serverName varchar(250) not null,
			portNumber varchar(250) not null,
			databaseName varchar(250) not null,
			userName varchar(250) not null,
			passswordUser varchar(250) not null,
			TrustedConnection varchar(250) not null,
			TypeDeployment varchar(250) not null,
		)

# PARAMETROS A TENER EN CUENTA  - Prestamos_Key
==========================

## TABLAS
### KeyConnect
				idKey					---> SE GRABA SIN MODIFICACIONES - ES AUTO INCREMENTABLE
				serverName				---> SE GRABA DE FORMA ENCRIPTADA - ENCRIPTAMIENTO SE REALIZA DESDE EL CONTROLADOR
				portNumber				---> SE GRABA DE FORMA ENCRIPTADA - ENCRIPTAMIENTO SE REALIZA DESDE EL CONTROLADOR 
				databaseName			---> SE GRABA DE FORMA ENCRIPTADA - ENCRIPTAMIENTO SE REALIZA DESDE EL CONTROLADOR 
				userName				---> SE GRABA DE FORMA ENCRIPTADA - ENCRIPTAMIENTO SE REALIZA DESDE EL CONTROLADOR 
				passswordUser			---> SE GRABA DE FORMA ENCRIPTADA - ENCRIPTAMIENTO SE REALIZA DESDE EL CONTROLADOR 
				TrustedConnection		---> SE GRABA DE FORMA ENCRIPTADA - ENCRIPTAMIENTO SE REALIZA DESDE EL CONTROLADOR 
				TypeDeployment			---> SE GRABA DE FORMA ENCRIPTADA - ENCRIPTAMIENTO SE REALIZA DESDE EL CONTROLADOR 