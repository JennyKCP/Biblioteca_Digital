# 1. Proyecto: Gestión de Biblioteca Digital  

Este proyecto de documentará fase por fase, desde lo mas básico a lo avanzado, para mayor entendimiento y que cualquier persona pueda seguirlo sin tener ningun problema. 


**INDICE**
- [1. Proyecto: Gestión de Biblioteca Digital](#1-proyecto-gestión-de-biblioteca-digital)
	- [1.1. Instalación de Herramientas Necesarias](#11-instalación-de-herramientas-necesarias)
- [2. Fases del Proyecto](#2-fases-del-proyecto)
	- [2.1. Fase 1](#21-fase-1)
		- [2.1.1. Estructura del Proyecto en la Fase 1](#211-estructura-del-proyecto-en-la-fase-1)
		- [2.1.2. Creación de la Estructura Básica](#212-creación-de-la-estructura-básica)
- [3. Anexos](#3-anexos)
	- [3.1. Anexo 1: Configuración de llaves SSH en GitHub](#31-anexo-1-configuración-de-llaves-ssh-en-github)


## 1.1. Instalación de Herramientas Necesarias  

Antes de comenzar, asegúrate de tener instaladas estas herramientas:  

1. **Visual Studio Code** (editor de código)  
   - Descargar desde: [https://code.visualstudio.com/](https://code.visualstudio.com/Download)  

2. **.NET SDK (para C#)**  
   - Descargar desde: [https://dotnet.microsoft.com](https://dotnet.microsoft.com/download)
   
Una vez instalado, abre una terminal y escribe:  
   ```bash
   dotnet --version
   ```

Si aparece un número de versión, la instalación fue correcta.

3. **Git**
   - Descargar desde: [https://git-scm.com/downloads](https://git--scm-com.translate.goog/downloads?_x_tr_sl=en&_x_tr_tl=es&_x_tr_hl=es&_x_tr_pto=tc) 


Verifica la instalación con:

```bash
git --version
```

4. **GitHub** (repositorio en la nube)
   1. Crear una cuenta gratuita en: https://github.com

   2. Clonación del Repositorio en GitHub.
    - Copia la URL HTTPS o SSH del repositorio:
		- **SSH:** git@github.com:JennyKCP/Biblioteca_Digital.git  (Para este enlace debes de tener la llave .ssh en GitHub) **_Para mas información ir al anexo 1_**.
		- **HTTPS:** https://github.com/JennyKCP/Biblioteca_Digital.git (No requiere de ninguna llave).
  
- **DATO:** SSH usa claves criptográficas para una autenticación más segura, mientras que HTTPS usa un token de acceso o (anteriormente) usuario/contraseña.

5. **Prepara el Proyecto en tu PC** 
   
Abre Git Bash en la carpeta donde quieras guardar tu proyecto (Se recomienda el nombre de Biblioteca_Digital).

Clona el repositorio:

```bash
git clone HTTPS o SSH
```
Ingresa a la carpeta:

```bash
cd Biblioteca_Digital
```

Inicializa Git y conecta el proyecto con el repositorio:

```bash
git init
```
```bash
git remote add origin HTTPS o SSH
```

# 2. Fases del Proyecto

## 2.1. Fase 1

- **Convención de Nombres:**
Este proyecto utiliza PascalCase para clases, métodos y propiedades.

- Ejemplo:

	- Clase -> ListaDobleLibros
	- Método -> AgregarLibro()
	- Propiedad -> Titulo

### 2.1.1. Estructura del Proyecto en la Fase 1

```bash
Biblioteca_Digital/
│
├── BibliotecaDigital/            # Proyecto en C#
│   ├── Program.cs                # Punto de entrada del programa
│   ├── Libro.cs                  # Clase Libro con atributos
│   ├── NodoLista.cs              # Clase Nodo de la lista doble
│   ├── ListaDobleLibros.cs       # Clase Lista Doble con operaciones
│   └── BibliotecaDigital.csproj  # Configuración del proyecto
│
└── README.md                     # Documentación del proyecto
```

 - **Ejecución del Proyecto**
  
Abre una terminal en la carpeta BibliotecaDigital.

Escribe el siguiente comando:

```bash
dotnet run
```
Esto compilará y ejecutará tu aplicación.

### 2.1.2. Creación de la Estructura Básica

1. **Clase Libro**

Contiene los atributos:
```text
Titulo
Autor
Genero
Anio
Disponible
Ocupado
Prestado
```

Incluye el método `ToString()` para mostrar información en pantalla.

2. **Clase NodoLista**
   
Define los nodos de la lista doblemente enlazada.

Cada nodo contiene:
```text
Un objeto Libro.
Puntero al nodo anterior.
Puntero al nodo siguiente.
```

3. **Clase ListaDobleLibros**

Implementa la lista doble con los siguientes métodos:

```csharp
AgregarLibro() -> Inserta un libro al final.
EliminarLibro() -> Retira un libro por título.
RecorrerAdelante() -> Recorre desde el primero hasta el último.
RecorrerAtras() -> Recorre desde el último hasta el primero.
BuscarLibro() -> Busca un libro en la lista por título.
```


# 3. Anexos

## 3.1. Anexo 1: Configuración de llaves SSH en GitHub  

Configuración de una **llave SSH** para conectarte a GitHub de forma segura, sin necesidad de escribir tu usuario y contraseña cada vez que haces `git push` o `git pull`.  

1. **Verificar si ya existe una llave SSH**  

Abre **Git Bash** y ejecuta:  

```bash
ls -al ~/.ssh
```

Si ves archivos como:
```bash
id_rsa y id_rsa.pub
id_ed25519 y id_ed25519.pub
```
entonces ya tienes una llave creada. Si no aparecen, pasamos al siguiente paso.

2. **Crear una nueva llave SSH**

Ejecuta el siguiente comando en Git Bash:

```bash
ssh-keygen -t ed25519 -C "tu_correo_de_github@gmail.com"
```

- **Explicación:**
  - **-t ed25519** -> tipo de algoritmo (más seguro que RSA).
  - **-C "..."** -> tu correo vinculado a GitHub.

Cuando pida ruta para guardar la llave, presiona Enter (usa la predeterminada).

Cuando pida passphrase, puedes dejar vacío o escribir una contraseña para más seguridad.

3. **Iniciar el agente SSH**

Ejecuta en Git Bash:

```bash
eval "$(ssh-agent -s)"
```
```bash
ssh-add ~/.ssh/id_ed25519
```
4. **Copiar la llave pública**
Tu llave pública está en:

```bash
cat ~/.ssh/id_ed25519.pub
```

5. **Registrar la llave en GitHub**

- Ve a GitHub -> Settings -> SSH and GPG keys.
- Haz clic en New SSH key.
	- Ponle un título (ejemplo: Mi PC personal).
	- Pega la llave copiada y guarda.

6. **Probar conexión SSH**

En Git Bash, ejecuta:

```bash
ssh -T git@github.com
```
Si todo está correcto, verás un mensaje parecido a:

```vbnet
Hi tu-usuario! You're successfully authenticated, but GitHub does not provide shell access.
```

7. **Cambiar repositorio de HTTPS a SSH**
   
Si tu repo fue clonado con HTTPS, cámbialo a SSH:

```bash
git remote set-url origin git@github.com:tu-usuario/Biblioteca_digital.git
```
Verifica el cambio:

```bash
git remote -v
```
Debe mostrar algo como:

```scss
origin  git@github.com:tu-usuario/Biblioteca_digital.git (fetch)
origin  git@github.com:tu-usuario/Biblioteca_digital.git (push)
```

