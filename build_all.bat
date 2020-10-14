dotnet --version
dotnet build build\FontStashXNA.Monogame.sln /p:Configuration=Release --no-incremental

call copy_zip_package_files.bat
rename "ZipPackage" "FontStashXNA.%APPVEYOR_BUILD_VERSION%"
7z a FontStashXNA.%APPVEYOR_BUILD_VERSION%.zip FontStashXNA.%APPVEYOR_BUILD_VERSION%
