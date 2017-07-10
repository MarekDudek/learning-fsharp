#! /bin/bash

echo Literals ...
fsharpc ./src/Literals.fs -o ./trg/Literals.exe
chmod +x ./trg/Literals.exe
./trg/Literals.exe

echo ... AnonymousFunctions ...

fsharpc ./src/AnonymousFunctions.fs -o ./trg/AnonymousFunctions.exe
chmod +x ./trg/AnonymousFunctions.exe
./trg/AnonymousFunctions.exe

echo .
