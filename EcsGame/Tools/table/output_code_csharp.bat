SET WORKSPACE=%~dp0
SET SOURCETABLEDIR=%~dp0/../../Tables/Sources/
SET PROJECTTABLEDIR=%~dp0/../../UnityProject/EcsGame/Assets/Scripts/Game/Tables/

cd %WORKSPACE%
%~dp0/outputcode -i %SOURCETABLEDIR% -o %PROJECTTABLEDIR%

pause