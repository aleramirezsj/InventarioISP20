# Laboratorio: tu backend en el VPS

Cada uno tiene en el VPS su carpeta `/srv/react-aula/<usuario>` con un `compose.yml` que levanta su **frontend** (React/Vite).
Vamos a sumar ahí tu **backend** (este repo), con el mismo circuito que ya usás para el frontend: trabajás en tu compu, subís con WinSCP y levantás con Docker.

```
tu compu (InventarioISP20)  --WinSCP-->  /srv/react-aula/<usuario>/InventarioISP20
                                           docker compose up -d --build backend
https://<usuario>.isp20.edu.ar/api/...  --nginx-->  tu contenedor backend
```

## Tu puerto

El backend usa el puerto de tu frontend **cambiando el 5 inicial por un 8**.

| Usuario | Frontend | Backend |
|---------|----------|---------|
| cande   | 5173     | 8173    |
| dani    | 5174     | 8174    |
| luci    | 5176     | 8176    |
| vale    | 5177     | 8177    |
| ale     | 5178     | 8178    |

## 1. Preparar el repo en tu compu

```bash
git pull
```

Verificá que en la raíz estén `Dockerfile.backend` y `.dockerignore`. Probá que compile: `dotnet build Backend/Backend.csproj`.

## 2. Subir con WinSCP

1. Conectate al VPS con tu usuario y entrá a `/srv/react-aula/<usuario>`.
2. Creá la carpeta `InventarioISP20`.
3. Usá **Comandos → Sincronizar**, con tu carpeta local `InventarioISP20` a la izquierda y `/srv/react-aula/<usuario>/InventarioISP20` a la derecha, en dirección **Remoto**.
4. En **Máscara de archivos** poné esto, para no subir lo que no hace falta:

   ```
   | bin/; obj/; .vs/; .git/; .github/; AppMovil/; Desktop/; WebApp/; Consola/; .env; appsettings.json
   ```

Tienen que quedar arriba al menos: `Dockerfile.backend`, `.dockerignore`, `NuGet.Config`, `Backend/` y `Services/`.

## 3. Sumar el backend a tu compose (una sola vez)

El profe te deja el archivo `.env` con la conexión a la base, junto a tu `compose.yml`. **No lo borres, no lo copies a tu compu y no lo subas a ningún repo.**

1. Hacé una copia: `cp compose.yml compose.yml.bak`.
2. Agregá este servicio dentro de `services:`, al mismo nivel que tu frontend. Cambiá `8178` por **tu** puerto de backend:

```yaml
  backend:
    build:
      context: ./InventarioISP20
      dockerfile: Dockerfile.backend
    restart: unless-stopped
    environment:
      ASPNETCORE_ENVIRONMENT: Production
      ASPNETCORE_FORWARDEDHEADERS_ENABLED: "true"
      ConnectionStrings__postgresRemote: ${POSTGRES_CONN:?falta POSTGRES_CONN en .env}
    ports:
      - "127.0.0.1:8178:8080"
    mem_limit: 384m
    cpus: 1.0
    pids_limit: 256
    security_opt:
      - no-new-privileges:true
    cap_drop:
      - ALL
```

3. Validá el archivo: `docker compose config -q`. Si no imprime nada, está bien.

## 4. Levantar o actualizar el backend

Cada vez que cambies algo:

1. Sincronizá con WinSCP, como en el paso 2.
2. Por SSH:

```bash
cd ~
docker compose up -d --build backend
```

Esto reconstruye **solo el backend**: tu frontend no se reinicia.

## 5. Probar

```bash
curl -s http://127.0.0.1:8178/api/Paises      # usá tu puerto
docker compose logs -f backend                # ver logs (Ctrl+C para salir)
docker compose ps                             # estado de tus contenedores
```

Desde el navegador, cuando el profe haya conectado tu sitio: `https://<usuario>.isp20.edu.ar/api/Paises`.

Tu frontend tiene que llamar a la API con rutas **relativas** (`/api/Clientes`), no con la URL de Azure.

## Reglas del laboratorio

- **La base de datos es compartida.** No corras `dotnet ef database update` ni migraciones contra ella: le cambiarías el esquema a todos.
- Si rompés el compose, volvé a la copia: `cp compose.yml.bak compose.yml`.
- Si el build falla, leé el error del `dotnet publish` en la salida de `docker compose up --build`. Suele ser un error de compilación que también te aparece en tu compu.
- Si `/api/...` da 500, mirá `docker compose logs backend`. Ahí aparece el error de la base o de tu código.
