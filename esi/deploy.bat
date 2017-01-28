java -jar swagger-codegen-cli.jar generate ^
   -i esi.json ^
   -c esi-codegen.json ^
   -l csharp ^
   -o ./esi-lib