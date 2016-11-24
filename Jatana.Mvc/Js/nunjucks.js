var nunjucks = require('nunjucks'),
    fs = require('fs'),
    path = require('path');

var dirString = path.dirname(fs.realpathSync(__filename));
var viewsPath = dirString+'/../../Views';
var node = {version: process.version, platform: process.platform, pid: process.pid };

nunjucks.configure(viewsPath, { autoescape: true, watch: true });                    


return function(data, callback) {
    callback(null,
        
        nunjucks.render(data.template,
        {
            model: data.model,
            env: {
                viewsPath: viewsPath,
                node: node,
                stats: {
                    uptime: process.uptime(),
                    memory: process.memoryUsage()
                }
            }
        }));
}