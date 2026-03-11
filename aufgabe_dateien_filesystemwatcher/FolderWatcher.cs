using System;
using System.IO;
using System.Net;
using System.Threading;

public class FolderWatcher
{
    private FileSystemWatcher _watcher;
    private DnsResolver _resolverService;

    public FolderWatcher(string path)
    {
        _resolverService = new DnsResolver();
        
        _watcher = new FileSystemWatcher(path);
        _watcher.Filter = "*.lookup";
        _watcher.Created += OnCreated;
        _watcher.EnableRaisingEvents = true;
    }

    private void OnCreated(object sender, FileSystemEventArgs fsea)
    {
        _resolverService.ResolveDns(fsea.FullPath);
    }
}