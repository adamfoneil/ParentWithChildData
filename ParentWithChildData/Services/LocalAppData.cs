using System.Text.Json;

namespace ParentWithChildData.Services;

public class LocalAppData
{
	public async Task SaveAsync<T>(T data, string fileName)
	{
		var json = JsonSerializer.Serialize(data, new JsonSerializerOptions() { WriteIndented = true });

		var outputFile = Path.Combine(SaveLocation, fileName);

		var folder = Path.GetDirectoryName(outputFile);
		if (!Directory.Exists(folder)) Directory.CreateDirectory(folder!);

		await File.WriteAllTextAsync(outputFile, json);
	}

	public string SaveLocation => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BlazorDemo");
}
