rem delete existing
rmdir "ZipPackage" /Q /S

rem Create required folders
mkdir "ZipPackage"
mkdir "ZipPackage\MonoGame"

set "CONFIGURATION=Release\net45"

rem Copy output files
copy "src\bin\MonoGame\%CONFIGURATION%\FontStashXNA.dll" "ZipPackage\MonoGame" /Y
copy "src\bin\MonoGame\%CONFIGURATION%\FontStashXNA.pdb" "ZipPackage\MonoGame" /Y