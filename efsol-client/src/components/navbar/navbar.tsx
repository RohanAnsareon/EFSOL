import { Toolbar, Typography } from '@material-ui/core';
import AppBar from '@material-ui/core/AppBar/AppBar';
import React from 'react';

const NavbarComponent: React.FunctionComponent<{title: string}> = ({title}) => {
    return (
        <AppBar position="static" color="default">
            <Toolbar>
                <Typography variant="h6">
                    {title}
                </Typography>
            </Toolbar>
        </AppBar>
    )
}

export default NavbarComponent;