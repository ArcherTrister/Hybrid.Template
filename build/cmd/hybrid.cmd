::此命令行工具是用来生成项目代码的，一键生成
::更新模板
@echo off
echo 正在更新最新版本的 Hybrid.Template.Mvc_Angular
dotnet new -i Hybrid.Template.Mvc_Angular
:: 输出空行
echo= 
echo, 
echo; 
::生成代码
echo －－－－－－－－－－－－－－－－－－－－－－－－－
echo － 欢迎使用 Hybrid一键模板 命令
echo － 当前版本：1.0.7-beta03
echo － https://www.lxking.cn
echo － Copyright © 2019 - 2020 LXKING.CN
echo －－－－－－－－－－－－－－－－－－－－－－－－－
echo 请输入项目名称，推荐形如 “公司.项目”的模式：
set name=:
set /p name=
dotnet new hybrid_sln -n %name%
dotnet new hybrid_core -n %name% -o %name%\src\%name%.Core
dotnet new hybrid_entityconfig -n %name% -o %name%\src\%name%.EntityConfiguration
dotnet new hybrid_mvc -n %name% -o %name%\src\%name%.Web
dotnet new hybrid_ng -o %name%\src\ui
echo 项目代码生成完成
pause