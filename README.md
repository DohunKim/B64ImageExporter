# B64ImageExporter
this library(dll) export Base64 encoded image to image file. this dll is based on .Net framework and also can be used from classic asp.

Usage on classic ASP:
> dim b64, ext

> Set b64 = server.createobject("B64ImgExporter.B64ImgExporter")

> fileExtension = b64.ExportToFile(base64encodedstring, Server.MapPath("./filename"))
