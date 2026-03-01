# Votación Voceros

Aplicación de escritorio desarrollada en **Visual Basic .NET** para gestionar el proceso de votación de voceros.  
El sistema permite registrar votantes, administrar usuarios, contar votos, generar reportes y garantizar la integridad de la información utilizando bases de datos Access.

## 🚀 Características
- Registro de votantes y control de duplicados.
- Autenticación de administrador y gestión de contraseñas.
- Conteo de votos diurno y nocturno.
- Reportes personalizados con RDLC.
- Integración con bases de datos Access (.accdb).
- Interfaz gráfica intuitiva en Windows Forms.

## 🛠️ Tecnologías utilizadas
- **Lenguaje:** Visual Basic .NET
- **Framework:** .NET Framework
- **Base de datos:** Microsoft Access
- **Reportes:** RDLC
- **IDE recomendado:** Visual Studio

## 📂 Estructura del proyecto
- `Administrador.*`: Formularios para administración de usuarios.
- `Registro.*`: Registro de votantes.
- `VotosD.* / VotosN.*`: Conteo de votos diurnos y nocturnos.
- `ReporteDia.rdlc / ReporteNoche.rdlc`: Reportes de resultados.
- `Basedatosvotacion.accdb / tblcomp.accdb`: Bases de datos del sistema.
- `App.config`: Configuración de la aplicación.

## ⚙️ Requisitos previos
- Windows 10 o superior.
- [Visual Studio](https://visualstudio.microsoft.com/) con soporte para Visual Basic .NET.
- Microsoft Access Database Engine.
- .NET Framework 4.x instalado.

## ▶️ Ejecución
1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/votacion-voceros.git
2. Abrir el archivo `VotacionVoceros.vbproj` en Visual Studio.
3. Restaurar los paquetes si es necesario (`packages.config`).
4. Configurar la conexión a las bases de datos Access si fuera requerido.
5. Ejecutar el proyecto (F5).

---

## 📬 Contacto

> Desarrollado con cariño por [@JhonSnakee](https://github.com/JhonSnakee)
