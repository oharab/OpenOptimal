require 'albacore'
require 'version_bumper'

@prerelease='alpha'

task :default => [:msbuild]

desc "Build the solution"
msbuild :msbuild => [:bumpbuild, :assemblyinfo, :compilecss ] do |msb|	
  msb.properties = { :configuration => :Debug }
  msb.targets = [ :Clean, :Build ]
  msb.solution = "OpenOptimal.sln"
end

desc "create the assembly info"
assemblyinfo :assemblyinfo do |asm|
  asm.version = bumper_version.to_s
  asm.file_version = bumper_version.to_s
  asm.custom_attributes :AssemblyInformationalVersion => bumper_version.to_s + '-' + @prerelease
  
  asm.company_name = "West Yorkshire Police"
  asm.product_name = "Open Optimal"
  asm.copyright = "Copyright ©2012 West Yorkshire Police"
  
  asm.output_file = "src/OpenOptimal.web/Properties/AssemblyInfo.cs"
end

desc "Increase the build number"
task :bumpbuild do
  bumper_version.bump_build
  bumper_version.write('version')
end

desc "compile the css from sass"
task :compilecss do
  system "compass compile -c compass.rb --force"
end