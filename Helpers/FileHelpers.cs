using static Ubunifu.Constants;

namespace Ubunifu;
public static class FileHelpers {
    public static FileInfo? GetProjectFile(string projectName = "") {
        var files = Directory.GetFiles(Environment.CurrentDirectory, projectFilePattern);
        if(files.Length == 0) return null;
        if(files.Length == 1) return new FileInfo(files[0]);
        
        // There is more than one project file and project name is not specified
        if(string.IsNullOrWhiteSpace(projectName)) {
            throw new Exception("There is more than one project file. Please specify the project where the model is declared using -p or --project");
        }

        FileInfo? fileInfo = null;
        foreach (var file in files)
        {
            fileInfo = new FileInfo(file);
            if(fileInfo.Name == $"{projectName}.csproj") {
                return fileInfo;
            }
        }
        return fileInfo;
    }
}
