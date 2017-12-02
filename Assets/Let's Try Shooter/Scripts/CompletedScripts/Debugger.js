import System;
import System.IO;
 
static function Log (debugMsg : String) {
      var path : String = Application.dataPath+"/debugLog.txt";
      var sw : StreamWriter = new StreamWriter(path, true);
      sw.WriteLine(debugMsg+"\n");
      sw.Close();
}  