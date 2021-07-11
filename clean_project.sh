@echo off
echo Deleting Junk
echo .
echo ..
echo ...
rm -R Saved/*
rm -R Intermediate/*
rm -R Build/*
rm -R Builds/*
rm -R Binaries/*
find . -type f -name "*.log" -exec rm -f {} \;
echo Project at minimum size
echo Goodbye
#ping google.com -n 6 google.com > nul
read -p "Press any key to continue... " -n1 -s