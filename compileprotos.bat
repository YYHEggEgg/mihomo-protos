mkdir Compiled
del Compiled\*.cs
protoc --proto_path="Protos" "Protos/*.proto" --csharp_out="Compiled"