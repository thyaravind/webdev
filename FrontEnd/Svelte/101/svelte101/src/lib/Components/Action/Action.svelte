<script>
    export let buttonText;
    export let isOutline;
    </script>
    
    
    {#if isOutline}
    <button id="buttonOutline"
            type="button">
        {buttonText}
    </button>
    {:else}
    <button id="buttonPrimary"
            type="button">
        {buttonText}
    </button>
    {/if}
    
    
    <style>

        :root{
            --width: 180px;
            --height: 100px
        }
    
    #buttonOutline{
        background-color: var(--secondary-color);
        color: var(--primary-color);
        border: 2px solid;
        border-radius: 8px;
        width: var(--width);
        height: var(--height);
    }
    
    #buttonPrimary{
        background-color: var(--primary-color);
        color: var(--secondary-color);
        border-radius: 8px ; 
        width: var(--width);
        height: var(--height);  
    }
    
    </style>
    