# Sistema de Votación de Voceros

Aplicación de escritorio desarrollada en **Visual Basic .NET (Windows Forms)** para gestionar la elección de voceros por jornada (día y noche) en una institución educativa. Utiliza bases de datos **Microsoft Access (.accdb)** como almacenamiento local.

---

## Características

- Registro, modificación, búsqueda y eliminación de votantes
- Votación separada por jornada: **Diurna** y **Nocturna**
- Validación para evitar que un mismo estudiante vote más de una vez
- Panel de administrador protegido por contraseña
- Generación de reportes por jornada (formato RDLC)
- Carga dinámica de imágenes de candidatos desde archivos `.txt`
- Reinicio completo de conteos de votos desde el panel administrador
- Cambio de contraseña de administrador

---

## Tecnologías

| Componente | Detalle |
|---|---|
| Lenguaje | Visual Basic .NET |
| Framework | .NET Framework 4.6.1 |
| Interfaz | Windows Forms |
| Base de datos | Microsoft Access 2016+ (`.accdb`) vía OleDb |
| Reportes | Microsoft RDLC (ReportViewer 15.x) |
| IDE recomendado | Visual Studio 2017 o superior |

---

## Estructura del proyecto

```
sistemaVotaciones/
├── Accesorios/                   # Copias de las bases de datos
├── Complementos/
│   ├── Instrucciones.txt         # Pasos de instalación
│   └── BD/                       # Bases de datos limpias para distribución
└── VotacionVoceros/
    └── VotacionVoceros/
        ├── Basedatosvotacion.accdb   # Registro de votantes
        ├── tblcomp.accdb             # Conteo de votos por jornada
        ├── Inicio.vb                 # Menú principal
        ├── Registro.vb               # CRUD de votantes
        ├── SelectJorn.vb             # Selección de jornada
        ├── VotosD.vb                 # Formulario de votación diurna
        ├── VotosN.vb                 # Formulario de votación nocturna
        ├── Administrador.vb          # Panel de administración
        ├── ConClaveAdmin.vb          # Autenticación de administrador
        ├── CambiarContraseña.vb      # Cambio de contraseña
        ├── ReporteDia.vb/.rdlc       # Reporte jornada diurna
        ├── ReporteNoche.vb/.rdlc     # Reporte jornada nocturna
        ├── Eliminar.vb               # Eliminación de registros de votos
        └── Module1.vb                # Módulo global (constante Z = 0)
```

---

## Bases de datos

### `Basedatosvotacion.accdb`
Contiene la tabla `Votantes` con los campos:
- `Ficha` — número de ficha del aprendiz
- `Programa` — programa de formación
- `Tipo_Documento` — tipo de documento de identidad
- `No_Documento` — número de documento
- `Nombres_y_Apellidos` — nombre completo

### `tblcomp.accdb`
Almacena los conteos de votos separados por jornada:
- `VotosDia` — resultados de la jornada diurna
- `VotosNoche` — resultados de la jornada nocturna
- `YaVotaron` — control de votantes que ya ejercieron su voto

---

## Imágenes de candidatos

Las fotos de los candidatos se cargan dinámicamente desde archivos de texto ubicados en `C:\VotacionesCME\`:

| Archivo | Uso |
|---|---|
| `Imagen.txt` / `ImagenN.txt` | Candidato 1 (jornada día / noche) |
| `Imagen2.txt` / `ImagenN2.txt` | Candidato 2 |
| `Imagen3.txt` / `ImagenN3.txt` | Candidato 3 |

Cada archivo debe contener la ruta absoluta de la imagen del candidato correspondiente.

---

## Instalación y configuración

### Requisitos previos
- Windows 7 o superior
- .NET Framework 4.6.1
- Microsoft Access Database Engine 2016 (ACE OleDB 12.0)

### Pasos

1. Compilar la solución `VotacionVoceros.sln` en Visual Studio o ejecutar el instalador generado.
2. Copiar los archivos `.accdb` desde `Complementos/BD/` al directorio de datos de la aplicación (`|DataDirectory|`, que corresponde a la carpeta `bin\Debug` o la ruta de instalación).
3. Crear el directorio `C:\VotacionesCME\` y agregar los archivos `.txt` con las rutas de las imágenes de los candidatos.
4. Ejecutar la aplicación.

---

## Flujo de uso

```
Inicio
 ├── Registrar votante       → Formulario CRUD de Votantes
 ├── Votar
 │    ├── Jornada Diurna     → Selección de candidato + registro de voto
 │    └── Jornada Nocturna   → Selección de candidato + registro de voto
 └── Administrador (clave)
      ├── Ver reporte diurno
      ├── Ver reporte nocturno
      ├── Ver imágenes de jornada
      ├── Eliminar registros
      ├── Reiniciar todos los votos
      └── Cambiar contraseña
```

---

## Notas

- La aplicación está diseñada para ejecutarse en un entorno de red local o en un único equipo de votación.
- El reinicio de votos desde el panel administrador pone a cero todas las tablas `YaVotaron`, `ContVotosD` y `ContVotosN`.
- Para repetir el proceso electoral en un nuevo periodo, se recomienda hacer una copia de seguridad de las bases de datos antes de reiniciar.

---

## 👤 Autor

> Desarrollado con cariño por [@JhonSnakee](https://github.com/JhonSnakee)