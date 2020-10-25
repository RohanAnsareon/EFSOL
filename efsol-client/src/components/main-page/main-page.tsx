import { Button } from '@material-ui/core';
import React, { Dispatch, SetStateAction } from 'react';
import './main-page.css'

interface Props {
    setApproved: Dispatch<SetStateAction<boolean>>
}

const MainPageComponent = (props: Props) => {
    return (
        <div className="container">
            <h1>Do you want to start questionary?</h1>
            <Button variant="outlined" color="primary" onClick={() => props.setApproved(true)}>Let's Go!</Button>
        </div>
    )
}

export default MainPageComponent;