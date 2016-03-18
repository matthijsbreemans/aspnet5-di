
$DNU = "dnu"
$DNVM = "dnvm"

# ensure the correct version
& $DNVM install 1.0.0-rc1-update1

# use the correct version
& $DNVM use 1.0.0-rc1-update1

& $DNU restore "$ProjectJsonPath"
& $DNU build "$ProjectJsonPath"
