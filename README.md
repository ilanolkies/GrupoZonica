# GrupoZonica
Radios de Grupo Zonica https://radiozonica.com.ar

## App setup

### iOS

Habilitar Http en `Info.plist`
```xml
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
<key>NSExceptionDomains</key>
<dict>
<key>radiozonica.com.ar</key>
<dict>
<key>NSExceptionAllowsInsecureHTTPLoads</key>
<true/>
<key>NSIncludesSubdomains</key>
<true/>
</dict>
</dict>
</dict>
</plist>
```

### Android

Habilitar Http en `Android.Manifest`
```xml
<?xml version="1.0" encoding="utf-8"?>
<manifest ...>
    ...
    <uses-permission android:name="android.permission.INTERNET" />
    <application ... android:usesCleartextTraffic="true"></application>
</manifest>
```

### Imagenes

**Fijas**
- `share.png`

**Variables**
- `logo.png`

### Links
- Link a nombre y banner de programa.
