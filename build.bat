dotnet build

cd src/ui/ng-alain
npm install && npm run-script build && del ..\..\Hybrid.Template.Web\wwwroot\* /q && copy dist\* ..\..\Hybrid.Template.Web\wwwroot\ && cd ..\..\Hybrid.Template.Web && dotnet build -c Release && dotnet publish -c Release && cd ..\..\ && docker build -t hybrid.template.web .
